using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DTO;

namespace Logik
{
    class Preview_controller
    {
        private lokalDB lokalDB_;

        public Preview_controller()
        {
            lokalDB = new lokalDB();
        }

        public void importerDatafil()
        {

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

        public Datasæt 10sekFrem()
        {

        }

        public Datasæt 10sekTilbage()
        {

        }
    }
}
