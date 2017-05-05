using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    class DTO_Datasæt
    {
        public List<string> Ip_ { get; set; }

        public List<string> MåltagerKommentar_ { get; set; }

        public List<string> AnsvarstagerKommentar_ { get; set; }

        public DTO_PatientData Pd_ { get; set; }

        public string MåltagerBrugerId_ { get; set; }

        public string AnsvarstagerBrugerId_ { get; set; }

        public DateTime Dato_ { get; set; }

        public int AntalMålinger_ { get; set; }

        public string AnsvarstagerOrg_ { get; set; }

        public List<double> Data_ { get; set; }

        public int SampleRateHz_ { get; set; }

        public int IntervalSek_ { get; set; }

        public string DataFormat_ { get; set; }

        public char BinEllerTxt_ { get; set; }

        public string MåleformatType_ { get; set; }

        public DateTime StartTid_ { get; set; }


        public DTO_Datasæt()
        {
            Ip_ = new List<string>();
            MåltagerKommentar_ = new List<string>();
            AnsvarstagerKommentar_ = new List<string>();
            Data_ = new List<double>();

            //Standard værdier
            Dato_ = DateTime.Now;
            StartTid_ = new DateTime(2017, 05, 03, 14, 40, 12);
            BinEllerTxt_ = 'B';
            SampleRateHz_ = 500;
            AnsvarstagerOrg_ = "Gruppe 6";
            IntervalSek_ = 86400;
            DataFormat_ = "andet";
            MåleformatType_ = "Double";
            AntalMålinger_ = 1;
            AnsvarstagerBrugerId_ = "NN";            
        }


        public string printMåltagerKommentarer()
        {
            string output = "Kommentarer: \n";

            foreach(string e in MåltagerKommentar_)
            {
                output += "" + e + "\n";
            }

            return output;
        }
    }
}
