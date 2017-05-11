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
        public List<DTO_Datasæt> SøgIOffDB(string søgeord)
        {
            List<DTO_Datasæt> dsList = new List<DTO_Datasæt>();

            string sql = "DECLARE @searchString NVARCHAR(100)" +
                "SET @searchString = '%" + søgeord + "%' " +
                "SELECT * FROM EKGMAELING " +
                "WHERE sfp_mt_kommentar LIKE @searchString " +
                "OR sfp_anskommentar LIKE  @searchString " +
                "OR borger_cprnr LIKE @searchString " +
                "OR dato LIKE @searchString " +
                "OR sfp_ans_org LIKE @searchString " +
                "OR sfp_ansvrmedarbjnr LIKE @searchString " +
                "OR sfp_maaltagermedarbjnr LIKE @searchString ";

            cmd = new SqlCommand(sql, conn);

            conn.Open();
            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    DTO_Datasæt ds = new DTO_Datasæt();
                    ds.EkgId_ = (long)rdr["ekgmaaleid"];
                    ds.AnsvarstagerKommentar_.Add((string)rdr["sfp_anskommentar"]);
                    ds.MåltagerKommentar_.Add((string)rdr["sfp_mt_kommentar"]);
                    ds.Pd_.CPRNummer_ = (string)rdr["borger_cprnr"];
                    ds.Dato_ = (DateTime)rdr["dato"];
                    ds.AnsvarstagerOrg_ = (string)rdr["sfp_ans_org"];
                    ds.AnsvarstagerBrugerId_ = (string)rdr["sfp_ansvrmedarbjnr"];
                    ds.MåltagerBrugerId_ = (string)rdr["sfp_maaltagermedarbjnr"];

                    ds.SøgeResultat_ = omskrivSøgeResultat(rdr, søgeord);

                    dsList.Add(ds);
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show("" + ex);
                return null;
            }

            conn.Close();
            return dsList;
        }

        //Omskriver fundne værdier til et søgeresultat
        private string omskrivSøgeResultat(SqlDataReader sqlRdr, string søgOrd)
        {
            string output = "";

            output += "Ansvarstagers kommentar: " + sqlRdr["sfp_anskommentar"] + "\r\n";

            if (Convert.ToString(sqlRdr["sfp_mt_kommentar"]).Contains(søgOrd))
            {
                output += "Måletagers kommentar: " + sqlRdr["sfp_mt_kommentar"] + "\r\n";
            }

            if (Convert.ToString(sqlRdr["borger_cprnr"]).Contains(søgOrd))
            {
                output += "Borgers CPR-nummer: " + sqlRdr["borger_cprnr"] + "\r\n";
            }

            if (Convert.ToString(sqlRdr["dato"]).Contains(søgOrd))
            {
                output += "Dato for måling: " + sqlRdr["dato"] + "\r\n";
            }

            if (Convert.ToString(sqlRdr["sfp_ans_org"]).Contains(søgOrd))
            {
                output += "Ansvarstagers organisation" + sqlRdr["sfp_ans_org"] + "\r\n";
            }

            if (Convert.ToString(sqlRdr["sfp_ansvrmedarbjnr"]).Contains(søgOrd))
            {
                output += "Ansvarstagers medarbejdrnr.: " + sqlRdr["sfp_ansvrmedarbjnr"] + "\r\n";
            }

            if (Convert.ToString(sqlRdr["sfp_maaltagermedarbjnr"]).Contains(søgOrd))
            {
                output += "Måletagers medarbejdernr.: " + sqlRdr["sfp_maaltagermedarbjnr"] + "\r\n";
            }

            return output;
        }

        //Henter data tilhørende et valgt datasæt
        public DTO_Datasæt downloadDataFraOffDB(DTO_Datasæt ds)
        {
            string sql = "SELECT * FROM EKGDATA WHERE ekgmaaleid =" + ds.EkgId_;

            cmd = new SqlCommand(sql, conn);

            conn.Open();
            try
            {
                rdr = cmd.ExecuteReader();

                if (rdr.Read() && (long)rdr["ekgmaaleid"] == ds.EkgId_)
                {
                    ds.SampleRateHz_ = (int)rdr["samplerate_hz"];
                    ds.IntervalSek_ = (int)rdr["interval_sec"];
                    ds.DataFormat_ = (string)rdr["data_format"];
                    ds.BinEllerTxt_ = (char)rdr["bin_eller_tekst"];
                    ds.MåleformatType_ = (string)rdr["maaleformat_type"];
                    ds.StartTid_ = (DateTime)rdr["start_tid"];

                    byte[] bytes = (byte[])rdr["raa_data"];

                    for (int i = 0; i < bytes.Length; i += 8)
                    {
                        ds.Data_.Add(BitConverter.ToDouble(bytes, i));
                    }
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show("" + ex);
                return null;
            }

            conn.Close();
            return ds;
        }


        //
        //Use-case 6
        //

    }
}
