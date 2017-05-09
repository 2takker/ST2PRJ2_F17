using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DB;

namespace ST2PRJ2_F17
{
    class Gennemse_data_controller
    {
        private lokalDB lokalDB_;
        private DTO_Datasæt dtoDatasæt_;
        private List<DTO_Datasæt> dtoDatasætList_;
        private DTO_PatientData dtoPD_;
        
        public Gennemse_data_controller()
        {
            lokalDB_ = new lokalDB();
            dtoDatasæt_ = new DTO_Datasæt();
            dtoDatasætList_ = new List<DTO_Datasæt>();
            dtoPD_ = new DTO_PatientData();
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

                return true;
            }

            else
            {
                return false;
            }
        }

        public List<DTO_Datasæt> visPatientData(string cpr)
        {
            dtoDatasætList_  == lokalDB_.hentData(cpr);
            {                
                return dtoDatasætList_;
            }
             
        }
    }
}
