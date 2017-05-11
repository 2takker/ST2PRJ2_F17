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
        private const string offDbPass = "F17sST2PRJ2OffEKGDatabase";

        public OffentligDB()
        {
            conn = new SqlConnection(@"Data Source=i4dab.ase.au.dk; " +
                "Initial Catalog=F17ST2PRJ2OffEKGDatabase; " +
                "Integrated Security=False;" +
                "User ID=" + offDb + ";" +
                "Password=" + offDbPass + ";" +
                "Connect Timeout=15;" +
                "Encrypt=False;" +
                "TrustServerCertificate=False");
        }

        public List<DTO_Datasæt> SøgIOffDB (DTO_Datasæt ds)
        {
            List<DTO_Datasæt> dsList = new List<DTO_Datasæt>();


            return dsList;
        }
            
          
            
    }
}
