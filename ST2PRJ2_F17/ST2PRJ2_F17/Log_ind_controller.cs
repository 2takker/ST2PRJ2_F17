using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using Præsentationslag;
using DTO;
using System.Windows.Forms;

namespace Logik
{
    class Log_ind_controller
    {
        private lokalDB lokalDB_;
        private Hjemmeskærm hjemmeskærm_;
        private log_ind loginskærm_;

        public Log_ind_controller(bool ini)
        {
            lokalDB_ = new lokalDB();
            if (ini)
            {                
                hjemmeskærm_ = new Hjemmeskærm(true);

                loginskærm_ = new log_ind(true);
                loginskærm_.åbenLoginVindue(loginskærm_);

                Application.Run(hjemmeskærm_);                
            }
            else
            {
                hjemmeskærm_ = new Hjemmeskærm(false);
                loginskærm_ = new log_ind(false);
            }
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
