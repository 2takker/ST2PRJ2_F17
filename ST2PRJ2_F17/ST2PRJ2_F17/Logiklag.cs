using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace Logik
{
    class Logiklag
    {
        private lokalDB lokDB;

        public void login(DTO_Sundhedspersonale sundhedspersonale)
        {
            data.validerLogin(sundhedspersonale);
        }

        public void importerDatafil()
        {

        }

        public void gemDatasæt()
        {

        }

        public string indlæsCPR(string cpr)
        {            
            if (validerCPR(cpr) == true)
                return cpr;
            else return null;
        }

        private bool validerCPR(string cpr)
        {
            int[] talvægt = { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };

            int sum = 0;
            if (cpr.Length == 10)
            {
                for (int i = 0; i < cpr.Length; i++)
                {
                    char[] chars = cpr.ToCharArray();
                    sum += (chars[i] - 0x30) * talvægt[i];
                }
                int res = sum % 11;
                if (res == 0)
                    return true;
            }
            return false;
        }


    }
}
