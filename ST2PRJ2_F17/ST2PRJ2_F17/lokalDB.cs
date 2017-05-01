using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DB
{
    class lokalDB
    {
        private SqlConnection conn;
        private SqlDataReader rdr;
        private SqlCommand cmd;
        private const string db = "F17ST2ITS2201500391";
        private DTO_Sundhesdpersonale sp_;


        public lokalDB()
        {
            conn = new SqlConnection("Data Source =i4dab.ase.au.dk; Initial Catalog=" + db +
                ";Persist Security Info = True; User ID=" + db + ";Password=" + db + "");            
        }


        public DTO_Sundhedspersonale validerLogin(DTO_Sundhedspersonale sp)
        {
            cmd = new SqlCommand("SELECT * FROM Sundhedspersonale WHERE bruger_id ='" + sp.BrugerID_ + "'", conn);

            conn.Open();

            rdr = cmd.ExecuteReader();

            sp_ = new DTO_Sundhesdpersonale(null, null);

            while(rdr.Read())
            {
                if (Convert.ToString(rdr["kodeord"]) == sp.Kodeord_ && Convert.ToString(rdr["bruger_id"]) == sp.BrugerID_) 
                {
                    sp_ = new DTO_Sundhesdpersonale(Convert.ToString(rdr["bruger_id"]), Convert.ToString(rdr["kodeord"]));
                }                
            }

            conn.Close();
            

            return sp_;
        }

    }
}
