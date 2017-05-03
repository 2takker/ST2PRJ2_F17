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

        public lokalDB()
        {
            conn = new SqlConnection("Data Source =i4dab.ase.au.dk; Initial Catalog=" + db +
                ";Persist Security Info = True; User ID=" + db + ";Password=" + db + "");
        }


        //
        //Use-case 1
        //

        public DTO_Sundhedspersonale validerLogin(DTO_Sundhedspersonale sp)
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
        

        //
        //Use-case 2
        //

        public bool findCPR(string cpr)
        {
            cmd = new SqlCommand("SELECT * FROM PatientData WHERE CPR ='" + cpr + "'", conn);

            conn.Open();

            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                if(cpr == Convert.ToString(rdr["CPR"]))
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

        public void gemDatasæt(DTO_Datasæt ds)
        {
            cmd = new SqlCommand("INSERT INTO ")
        }

        //
        //Use-case 3
        //

        //finder patient i lokaldatabase
        public bool findPatient(DTO_PatientData pd)
        {
            return findCPR(pd.CPRNummer_);

            //
            //Obsolete
            //
            //cmd = new SqlCommand("SELECT * FROM PatientData WHERE CPR ='" + pd.CPRNummer_ + "'", conn);

            //conn.Open();

            //rdr = cmd.ExecuteReader();

            //while (rdr.Read())
            //{
            //    if (pd.CPRNummer_ == Convert.ToString(rdr["CPR"]))
            //    {
            //        conn.Close();
            //        return true;
            //    }
            //    else
            //    {
            //        conn.Close();
            //        return false;
            //    }
            //}
            //conn.Close();
            //return false;
        }

        //Tilføjer patient til lokaldatabase
        public void tilføjPatient(DTO_PatientData pd)
        {
            cmd = new SqlCommand("INSERT INTO PatientData(CPR, Fornavn, Efternavn) VALUES('" + pd.CPRNummer_ + "', " +
                "'" + pd.Fornavn_ + "', '" + pd.Efternavn_ + "')",conn);

            conn.Open();

            cmd.ExecuteScalar();

            conn.Close();
        }

    }
}
