using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PatientData
    {
        private string cprNummer_;
        public string Fornavn_ { get; set; }
        public string Efternavn_ { get; set; }

        public string CPRNummer_
        {
            get { return cprNummer_; }
            set
            {
                cprNummer_ = (validerCPR(value) ? value : "1234567890");
            }
        }

        public DTO_PatientData(string cprNummer, string fornavn, string efternavn)
        {
            CPRNummer_ = cprNummer;
            Fornavn_ = fornavn;
            Efternavn_ = efternavn;
        }

        public DTO_PatientData(string cprNummer)
        {
            CPRNummer_ = cprNummer;           
        }

        public DTO_PatientData()
        {

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

    }
}
