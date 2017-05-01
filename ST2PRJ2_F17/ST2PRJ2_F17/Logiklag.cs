using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using Præsentationslag;
using DTO;

namespace Logik
{
    class Logiklag
    {
        private lokalDB lokalDB_;
        private Hjemmeskærm hjemmeskærm_;

        public Logik()
        {
            lokalDB_ = new lokalDB();
            hjemmeskærm_ = new Hjemmeskærm();
        }



        //Use case 1
        public string login(DTO_Sundhedspersonale sp)
        {
            DTO_Sundhedspersonale sp1 = lokalDB_.validerLogin(sp);

            if (sp1.BrugerID_ != null)
            {
                hjemmeskærm_.låsHjemmeskærm(false);
                return sp1.BrugerID_;
            }
            else
            {
                return null;
            }


        }








        //Use case 2
        //public void importerDatafil()
        //{

        //}

        //public void gemDatasæt()
        //{
        //    cpr_nummer_.åbenCPRVindue();
        //}



        //public string indlæsCPR(string cpr)
        //{
        //    if (validerCPR(cpr) == true)
        //        return cpr;
        //    else return null;
        //}

        //private bool validerCPR(string cpr)
        //{
        //    int[] talvægt = { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };

        //    int sum = 0;
        //    if (cpr.Length == 10)
        //    {
        //        for (int i = 0; i < cpr.Length; i++)
        //        {
        //            char[] chars = cpr.ToCharArray();
        //            sum += (chars[i] - 0x30) * talvægt[i];
        //        }
        //        int res = sum % 11;
        //        if (res == 0)
        //            return true;
        //    }
        //    return false;
        //}

        //public Datasæt 10sekFrem()
        //{

        //}

        //public Datasæt 10sekTilbage()
        //{

        //}
    }
}
