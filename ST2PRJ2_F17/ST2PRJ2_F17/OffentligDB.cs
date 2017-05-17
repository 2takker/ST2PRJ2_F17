using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DB
{
    class OffentligDB
    {
        private SqlConnection conn;
        private SqlDataReader rdr;
        private SqlCommand cmd;
        private const string offDb = "F17ST2PRJ2OffEKGDatabase";

        public OffentligDB()
        {
            conn = new SqlConnection(@"Data Source=i4dab.ase.au.dk; " +
                "Initial Catalog=" + offDb + "; " +
                "Integrated Security=False;" +
                "User ID=" + offDb + ";" +
                "Password=" + offDb + ";" +
                "Connect Timeout=15;" +
                "Encrypt=False;" +
                "TrustServerCertificate=False");
        }


        //
        // Use-case 5
        //

        //søger efter søgeord i offentlig database
        public List<DTO_Datasæt> søgIOffDB(string søgeord)
        {
            try
            {
                List<DTO_Datasæt> dsList = new List<DTO_Datasæt>();

                string sql = "DECLARE @searchString NVARCHAR(100) " +
                    "SET @searchString = '%" + søgeord + "%' " +
                    "SELECT * FROM EKGMAELING " +
                    "WHERE sfp_mt_kommentar LIKE @searchString " +
                    "OR sfp_anskommentar LIKE  @searchString " +
                    "OR borger_cprnr LIKE @searchString " +
                    "OR dato LIKE @searchString " +
                    "OR sfp_ans_org LIKE @searchString " +
                    "OR sfp_ansvrmedarbjnr LIKE @searchString " +
                    "OR sfp_maaltagermedarbjnr LIKE @searchString " +
                    "OR borger_fornavn LIKE @searchString " +
                    "OR borger_efternavn LIKE @searchString";

                cmd = new SqlCommand(sql, conn);

                conn.Open();

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    DTO_Datasæt ds = new DTO_Datasæt();
                    if (rdr["borger_cprnr"] != DBNull.Value)
                    {
                        ds.Pd_.CPRNummer_ = (string)rdr["borger_cprnr"];
                    }
                    if (rdr["borger_fornavn"] != DBNull.Value)
                    {
                        ds.Pd_.Fornavn_ = (string)rdr["borger_fornavn"];
                    }
                    if (rdr["borger_efternavn"] != DBNull.Value)
                    {
                        ds.Pd_.Efternavn_ = (string)rdr["borger_efternavn"];
                    }

                    ds.EkgId_ = (long)rdr["ekgmaaleid"];

                    if (rdr["sfp_anskommentar"] != DBNull.Value)
                    {
                        ds.AnsvarstagerKommentar_.Add((string)rdr["sfp_anskommentar"]);
                    }

                    if (rdr["sfp_mt_kommentar"] != DBNull.Value)
                    {
                        ds.MåltagerKommentar_.Add((string)rdr["sfp_mt_kommentar"]);
                    }

                    ds.Dato_ = Convert.ToDateTime(rdr["dato"]);
                    ds.AnsvarstagerOrg_ = (string)rdr["sfp_ans_org"];
                    ds.AnsvarstagerBrugerId_ = (string)rdr["sfp_ansvrmedarbjnr"];

                    if (rdr["sfp_maaltagermedarbjnr"] != DBNull.Value)
                    {
                        ds.MåltagerBrugerId_ = (string)rdr["sfp_maaltagermedarbjnr"];
                    }


                    ds.SøgeResultat_ = omskrivSøgeResultat(rdr, søgeord);

                    dsList.Add(ds);
                }

                conn.Close();
                return dsList;
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
                return null;
            }


        }

        //Omskriver fundne værdier til et søgeresultat
        private string omskrivSøgeResultat(SqlDataReader sqlRdr, string søgOrd)
        {
            string output = "";

            try
            {
                output += "Dato for måling: " + sqlRdr["dato"] + "\r\n";
                output += "Ansvarstagers kommentar: " + sqlRdr["sfp_anskommentar"] + "\r\n";

                if (Convert.ToString(sqlRdr["sfp_mt_kommentar"]).Contains(søgOrd))
                {
                    output += "Måletagers kommentar: " + sqlRdr["sfp_mt_kommentar"] + "\r\n";
                }

                if (Convert.ToString(sqlRdr["borger_cprnr"]).Contains(søgOrd))
                {
                    output += "Borgers CPR-nummer: " + sqlRdr["borger_cprnr"] + "\r\n";
                }

                if (Convert.ToString(sqlRdr["borger_fornavn"]).Contains(søgOrd))
                {
                    output += "Borgers fornavn: " + sqlRdr["borger_fornavn"] + "\r\n";
                }

                if (Convert.ToString(sqlRdr["borger_efternavn"]).Contains(søgOrd))
                {
                    output += "Borgers efternavn: " + sqlRdr["borger_efternavn"] + "\r\n";
                }

                if (Convert.ToString(sqlRdr["sfp_ans_org"]).Contains(søgOrd))
                {
                    output += "Ansvarstagers organisation: " + sqlRdr["sfp_ans_org"] + "\r\n";
                }

                if (Convert.ToString(sqlRdr["sfp_ansvrmedarbjnr"]).Contains(søgOrd))
                {
                    output += "Ansvarstagers medarbejdrnr.: " + sqlRdr["sfp_ansvrmedarbjnr"] + "\r\n";
                }

                if (Convert.ToString(sqlRdr["sfp_maaltagermedarbjnr"]).Contains(søgOrd))
                {
                    output += "Måletagers medarbejdernr.: " + sqlRdr["sfp_maaltagermedarbjnr"] + "\r\n";
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("" + ex);
            }

            return output;
        }

        //Henter data tilhørende et valgt datasæt
        public DTO_Datasæt downloadDataFraOffDB(DTO_Datasæt ds)
        {
            try
            {
                string sql = "SELECT * FROM EKGDATA WHERE ekgmaaleid =" + ds.EkgId_;

                cmd = new SqlCommand(sql, conn);

                conn.Open();

                rdr = cmd.ExecuteReader();

                if (rdr.Read() && (long)rdr["ekgmaaleid"] == ds.EkgId_)
                {
                    ds.SampleRateHz_ = Convert.ToDouble(rdr["samplerate_hz"]);
                    ds.IntervalSek_ = (long)rdr["interval_sec"];
                    ds.DataFormat_ = (string)rdr["data_format"];
                    ds.BinEllerTxt_ = Convert.ToChar(rdr["bin_eller_tekst"]);
                    ds.MåleformatType_ = (string)rdr["maaleformat_type"];
                    ds.StartTid_ = Convert.ToDateTime(rdr["start_tid"]);

                    byte[] bytes = (byte[])rdr["raa_data"];

                    for (int i = 0; i < bytes.Length; i += 8)
                    {
                        ds.Data_.Add(BitConverter.ToDouble(bytes, i));
                    }
                }

                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
                return null;
            }            
        }


        //
        //Use-case 6
        //

        //Gemmer et datasæt i den lokale database.
        public bool gemDatasæt(DTO_Datasæt ds, bool annonymt)
        {
            try
            {
                if (annonymt)
                {
                    ds.Pd_.CPRNummer_ = "1234567890";
                    ds.Pd_.Fornavn_ = "N";
                    ds.Pd_.Efternavn_ = "N";
                }

                string sql = "INSERT INTO EKGMAELING(dato, antalmaalinger, " +
                    "sfp_maaltagermedarbjnr, sfp_mt_kommentar, sfp_ansvrmedarbjnr, " +
                    "sfp_ans_org, sfp_anskommentar, borger_fornavn, borger_efternavn, " +
                    "borger_cprnr)" +
                    "OUTPUT INSERTED.ekgmaaleid " +
                    "VALUES(CONVERT(DATETIME, '" + ds.Dato_ + "'), " + ds.AntalMålinger_ + ", '"
                    + ds.MåltagerBrugerId_ + "', '" + ds.printMåltagerKommentar() + "', '"
                    + ds.AnsvarstagerBrugerId_ + "', '" + ds.AnsvarstagerOrg_ + "', '"
                    + ds.printIP() + "" + ds.printAnsvarstagerKommentar() + "', '"
                    + ds.Pd_.Fornavn_ + "', '" + ds.Pd_.Efternavn_ + "', '" + ds.Pd_.CPRNummer_ + "')";

                cmd = new SqlCommand(sql, conn);

                conn.Open();

                long ekgMåleId = (long)cmd.ExecuteScalar();

                conn.Close();

                sql = "INSERT INTO EKGDATA(raa_data, samplerate_hz, interval_sec, " +
                    "data_format, bin_eller_tekst, maaleformat_type, start_tid, ekgmaaleid) "
                    + "VALUES(@data, " + ds.SampleRateHz_ + ", " + ds.IntervalSek_ + ", '"
                    + ds.DataFormat_ + "', '" + ds.BinEllerTxt_ + "', '" + ds.MåleformatType_ + "', "
                    + "CONVERT(DATETIME, '" + ds.StartTid_ + "'), " + ekgMåleId + ")";

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
    }
}
