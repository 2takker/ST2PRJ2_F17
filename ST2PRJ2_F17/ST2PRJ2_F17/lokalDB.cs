using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;


namespace DB
{
    class lokalDB
    {
        private SqlConnection conn;
        private SqlDataReader rdr;
        private SqlCommand cmd;
        private const string db = "F17ST2ITS2201500391";
        private DTO_Sundhedspersonale sp_;

        //Default constructor
        public lokalDB()
        {
            conn = new SqlConnection("Data Source =i4dab.ase.au.dk; Initial Catalog=" + db +
                ";Persist Security Info = True; User ID=" + db + ";Password=" + db + "");
        }


        //
        //Use-case 1
        //

        //Validerer login, og sender brugerID tilbage i en DTO
        public DTO_Sundhedspersonale validerLogin(DTO_Sundhedspersonale sp)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Sundhedspersonale WHERE bruger_id ='" + sp.BrugerID_ + "'", conn);

                conn.Open();

                rdr = cmd.ExecuteReader();

                sp_ = new DTO_Sundhedspersonale(null, null);

                while (rdr.Read())
                {
                    if (Convert.ToString(rdr["kodeord"]) == sp.Kodeord_ && Convert.ToString(rdr["bruger_id"]) == sp.BrugerID_)
                    {
                        sp_ = new DTO_Sundhedspersonale(Convert.ToString(rdr["bruger_id"]), Convert.ToString(rdr["kodeord"]));
                    }
                }

                conn.Close();

                return sp_;
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
                return null;
            }
        }


        //
        //Use-case 2
        //

        //Fortæller om et cpr-nummer findes i lokal db
        public bool findCPR(string cpr)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM PatientData WHERE CPR ='" + cpr + "'", conn);

                conn.Open();

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (cpr == Convert.ToString(rdr["CPR"]))
                    {
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        conn.Close();
                        return false;
                    }
                }

                conn.Close();
                return false;
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
                return false;
            }
        }


        //gemmer et valgt datasæt i databasen
        //Bruges også til usecase 5
        public bool gemDatasæt(DTO_Datasæt ds)
        {
            try
            {
                string sql = "INSERT INTO EKGMAALING(dato, antalmaalinger, sfp_maaltagermedarbjnr, " +
                 "sfp_mt_kommentar, sfp_ansvrmedarbejnr, sfp_ans_org,  borger_cprnr, sfp_anskommentar)"
                 + " OUTPUT INSERTED.ekgmaaleid"
                 + " VALUES(CONVERT(DATETIME,'" + ds.Dato_.ToString("yyyy-MM-dd HH:mm:ss") + "')," + ds.AntalMålinger_ + ",'" + ds.MåltagerBrugerId_ + "','"
                     + ds.printMåltagerKommentar() + "','" + ds.AnsvarstagerBrugerId_ + "','"
                     + ds.AnsvarstagerOrg_ + "','" + ds.Pd_.CPRNummer_ + "' , '" + ds.printAnsvarstagerKommentar() + "')";

                cmd = new SqlCommand(sql, conn);

                conn.Open();

                long ekgMåleId = (long)cmd.ExecuteScalar();

                conn.Close();

                sql = "INSERT INTO EKGDATA(raa_data, samplerate_hz, interval_sec, data_format, " +
                       "bin_eller_tekst, maaleformat_type, start_tid, ekgmaaleid)"
                       + " VALUES(@data, " + ds.SampleRateHz_ + "," + ds.IntervalSek_ + ",'" + ds.DataFormat_ + "','"
                           + ds.BinEllerTxt_ + "','" + ds.MåleformatType_ + "', CONVERT(DATETIME,'" + ds.StartTid_.ToString("yyy-MM-dd HH:mm:ss") + "'),"
                           + ekgMåleId + ")";

                cmd = new SqlCommand(sql, conn);

                conn.Open();

                cmd.Parameters.AddWithValue("@data", ds.Data_.ToArray().SelectMany(value => BitConverter.GetBytes(value)).ToArray());

                cmd.ExecuteScalar();

                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
                return false;
            }
        }


        //
        //Use-case 3
        //

        //finder patient i lokaldatabase
        public bool findPatient(DTO_PatientData pd)
        {
            return findCPR(pd.CPRNummer_);
        }

        //Tilføjer patient til lokaldatabase
        public void tilføjPatient(DTO_PatientData pd)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO PatientData(CPR, Fornavn, Efternavn) VALUES('" + pd.CPRNummer_ + "', " +
                    "'" + pd.Fornavn_ + "', '" + pd.Efternavn_ + "')", conn);

                conn.Open();

                cmd.ExecuteScalar();

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
            }
        }


        //
        //Use-case 4
        //

        //Henter relevant data til visning, ud fra det søgte cpr
        public List<DTO_Datasæt> hentCPRData(string cpr)
        {
            try
            {
                //ekgmaaleid skal også sendes retur, da det er den vi skal bruge i findDatasæt til at finde ud af om den er analyseret eller ej. 
                DTO_Datasæt ds = new DTO_Datasæt();
                List<DTO_Datasæt> dsListe = new List<DTO_Datasæt>();


                //Finder CPR, dato og ID for de tilgængelige datasæt, tilknyttet det søgte CPR
                cmd = new SqlCommand("SELECT * FROM EKGMAALING WHERE borger_cprnr ='" + cpr + "' ORDER BY dato DESC", conn);
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (Convert.ToString(rdr["borger_cprnr"]) == cpr)
                    {
                        ds = new DTO_Datasæt();
                        ds.EkgId_ = (Convert.ToInt64(rdr["ekgmaaleid"]));
                        ds.Dato_ = (Convert.ToDateTime(rdr["dato"]));
                        ds.Pd_.CPRNummer_ = Convert.ToString(rdr["borger_cprnr"]);
                    }
                    dsListe.Add(ds);
                }

                conn.Close();


                //Tilføjer fornavn og efternavn til de fundne datasæt
                cmd = new SqlCommand("SELECT * FROM PatientData WHERE CPR ='" + cpr + "'", conn);
                conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    if (Convert.ToString(rdr["CPR"]) == ds.Pd_.CPRNummer_)
                    {
                        ds.Pd_.Fornavn_ = Convert.ToString(rdr["Fornavn"]);
                        ds.Pd_.Efternavn_ = Convert.ToString(rdr["Efternavn"]);

                        foreach (DTO_Datasæt e in dsListe)
                        {
                            e.Pd_.Fornavn_ = ds.Pd_.Fornavn_;
                            e.Pd_.Efternavn_ = ds.Pd_.Efternavn_;
                        }
                    }
                }

                conn.Close();

                return dsListe;
            }
            catch(Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
                return null;
            }
        }

        //Henter de valgte datasæt fra databasen
        public DTO_Datasæt hentDatasæt(DTO_Datasæt ds)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM EKGMAALING WHERE ekgmaaleid =" + ds.EkgId_, conn);

                conn.Open();

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    ds.MåltagerKommentar_.Add(Convert.ToString(rdr["sfp_mt_kommentar"]));
                    ds.AnsvarstagerKommentar_.Add(Convert.ToString(rdr["sfp_anskommentar"]));
                }
                conn.Close();


                cmd = new SqlCommand("SELECT * FROM EKGDATA WHERE ekgmaaleid =" + ds.EkgId_, conn);

                conn.Open();

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    if ((long)rdr["ekgmaaleid"] == ds.EkgId_)
                    {
                        ds.SampleRateHz_ = Convert.ToDouble(rdr["samplerate_hz"]);
                        ds.IntervalSek_ = Convert.ToInt64(rdr["interval_sec"]);
                        ds.DataFormat_ = (string)rdr["data_format"];
                        ds.BinEllerTxt_ = Convert.ToChar(rdr["bin_eller_tekst"]);
                        ds.MåleformatType_ = (string)rdr["maaleformat_type"];
                        ds.StartTid_ = Convert.ToDateTime(rdr["start_tid"]);

                        byte[] bytes = (byte[])rdr["raa_data"];

                        for (int i = 0; i < bytes.Length; i += 8)
                        {
                            ds.Data_.Add(BitConverter.ToDouble(bytes, i));
                        }


                        if (rdr["interessepunkter"] != DBNull.Value)
                        {
                            byte[] bytesIP = (byte[])rdr["interessepunkter"];

                            for (int i = 0; i < bytesIP.Length; i += 8)
                            {
                                ds.Ip_.Add(BitConverter.ToDouble(bytesIP, i));
                            }
                        }

                    }
                }

                conn.Close();
                return ds;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
                conn.Close();
                return null;
            }
        }

        //Skriver kommentar for ansvarstager til søgt ekg id
        public void gemKommentar(DTO_Datasæt ds)
        {
            try
            {
                string sql = "UPDATE EKGMAALING SET sfp_anskommentar = '"
                + ds.printAnsvarstagerKommentar() + "', sfp_ansvrmedarbejnr = '"
                + ds.AnsvarstagerBrugerId_ + "'  WHERE ekgmaaleid = " + ds.EkgId_;

                cmd = new SqlCommand(sql, conn);

                conn.Open();
                cmd.ExecuteScalar();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
            }

        }

        //Gemmer fundne interessepunkter til db
        public void gemIP(DTO_Datasæt ds)
        {
            try
            {
                string sql = "UPDATE EKGDATA SET interessepunkter = @data WHERE ekgmaaleid =" + ds.EkgId_; ;

                cmd = new SqlCommand(sql, conn);

                conn.Open();

                cmd.Parameters.AddWithValue("@data", ds.Ip_.ToArray().SelectMany(value => BitConverter.GetBytes(value)).ToArray());

                cmd.ExecuteScalar();

                conn.Close();
            }
            catch(Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
            }
        }
    }
}
