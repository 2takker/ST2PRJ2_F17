using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DTO;
using System.IO;

namespace Logik
{
    class Preview_controller
    {
        private lokalDB lokalDB_;
        private DTO_Datasæt dtoDatasæt_;
        

        public Preview_controller()
        {
            lokalDB_ = new lokalDB();
            dtoDatasæt_ = new DTO_Datasæt;
        }

        public List<string> importerDatafil(Stream st)
        {
            using (var fs = st)
            using (var reader = new StreamReader(fs))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',','\"');
                    
                    listB.Add(values[2]);
                }
                return listB;
            }
        }

        public void gemDatasæt()
        {

        }

        

        public bool validerCPR(string cpr)
        {
            int[] talVægt = { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };

            int sum = 0;
            if (cpr.Length == 10)
            {
                for (int i = 0; i < cpr.Length; i++)
                {
                    char[] chars = cpr.ToCharArray();
                    sum += (chars[i] - 0x30) * talVægt[i];
                }
                int res = sum % 11;
                if (res == 0)
                    return true;
            }
            return false;
        }

        public bool indlæsCPR(string cpr)
        {
            if (lokalDB_.findCPR(cpr) == true)
            {
                lokalDB_.gemDatasæt(Datasæt datasæt);
                return true;
            }

            else return false;                                            

        }
        
        public bool gemKommentar(string kommentar)
        {
            dtoDatasæt_.MåltagerKommentar_.Add(kommentar);
            return true; 
        }       
    }
}
