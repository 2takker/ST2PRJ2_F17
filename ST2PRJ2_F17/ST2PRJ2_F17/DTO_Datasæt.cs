using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ST2PRJ2_F17
{
    class DTO_Datasæt
    {
        public List<string> Ip_ { get; set; }

        public List<string> MåltagerKommentar_ { get; set; }

        public List<string> AnsvarstagerKommentar_ { get; set; }

        public DTO_PatientData Pd_ { get; set; }

        public string MåltagerBrugerId_ { get; set; }

        public string AnsvvarstagerBrugerId_ { get; set; }

        public DateTime Dato_ { get; set; }

        public int AntalMålinger { get; set; }

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
            Dato_ = DateTime.Now;
            StartTid_ = new DateTime(2017, 05, 03, 14, 40, 12);
            BinEllerTxt_ = 'B';
            SampleRateHz_ = 500;
            AnsvarstagerOrg_ = "Gruppe 6";
            //IntervalSek_ = 86400;
        }
    }
}
