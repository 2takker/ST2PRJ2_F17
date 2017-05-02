using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DTO;

namespace Logik
{
    class Opret_ny_patient_controller
    {
        private lokalDB lokalDB_;

        public Opret_ny_patient_controller()
        {
            lokalDB_ = new lokalDB();
        }

        private bool validerCPR(string cpr)
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

        public bool gemPatientData(DTO_PatientData patientData)
        {
            if (validerCPR(patientData.CPRNummer_) == false)
            {
                return false;
            }

            else
            {
                
                if (lokalDB_.findPatient(patientData) == false)
                {

                }

            }                
        }
        
    }
}
