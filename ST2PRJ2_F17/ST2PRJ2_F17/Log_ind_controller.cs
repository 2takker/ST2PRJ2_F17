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
    class Log_ind_controller
    {
        private lokalDB lokalDB_;
        private Hjemmeskærm hjemmeskærm_;
        private log_ind loginskærm_;

        public Log_ind_controller()
        {
            lokalDB_ = new lokalDB();
            //hjemmeskærm_ = new Hjemmeskærm();
            //loginskærm_ = new log_ind();
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
                loginskærm_.ugyldigtLogin();
                return null;
            }


        }


                
    }
}
