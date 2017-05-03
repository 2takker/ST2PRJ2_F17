using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_PatientData
    {
        public string CPRNummer_ { get; set; } 
        public string Fornavn_ { get; set; }
        public string Efternavn_ { get; set; }

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

    }
}
