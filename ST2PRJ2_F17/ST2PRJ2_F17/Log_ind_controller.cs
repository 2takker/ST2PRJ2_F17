using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DTO;
using System.Windows.Forms;

namespace Logik
{
    class Log_ind_controller
    {
        private lokalDB lokalDB_;

        public Log_ind_controller()
        {
            lokalDB_ = new lokalDB();            
        }


        //Use case 1
        public string login(DTO_Sundhedspersonale sp)
        {
            DTO_Sundhedspersonale sp1 = lokalDB_.validerLogin(sp);

            if (sp1.BrugerID_ != null)
            {
                return sp1.BrugerID_;
            }
            else
            {
                return null;
            }
        }



    }
}
