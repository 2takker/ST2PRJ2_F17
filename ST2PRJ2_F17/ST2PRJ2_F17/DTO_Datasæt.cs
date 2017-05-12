using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    public class DTO_Datasæt
    {
        public List<double> Ip_ { get; set; }

        public List<string> MåltagerKommentar_ { get; set; }

        public List<string> AnsvarstagerKommentar_ { get; set; }

        public DTO_PatientData Pd_ { get; set; }

        public string MåltagerBrugerId_ { get; set; }

        public string AnsvarstagerBrugerId_ { get; set; }

        public DateTime Dato_ { get; set; }

        public int AntalMålinger_ { get; set; }

        public string AnsvarstagerOrg_ { get; set; }

        public List<double> Data_ { get; set; }

        public double SampleRateHz_ { get; set; }

        private long intervalSek_;

        public string DataFormat_ { get; set; }

        public char BinEllerTxt_ { get; set; }

        public string MåleformatType_ { get; set; }

        public long EkgId_ { get; set; }

        public DateTime StartTid_ { get; set; }

        public string SøgeResultat_ { get; set; }

        public long IntervalSek_
        {
            get
            {
                return (Data_.Count / (int)SampleRateHz_);
            }
            set { }
        }

        public DTO_Datasæt()
        {
            Ip_ = new List<double>();
            MåltagerKommentar_ = new List<string>();
            AnsvarstagerKommentar_ = new List<string>();
            Data_ = new List<double>();
            Pd_ = new DTO_PatientData();
            Dato_ = new DateTime();

            //Standard værdier
            Dato_ = DateTime.Now;
            StartTid_ = DateTime.Now.AddDays(-1);
            BinEllerTxt_ = 'B';
            SampleRateHz_ = 500;
            AnsvarstagerOrg_ = "Gruppe 6";
            IntervalSek_ = 86400;
            DataFormat_ = "andet";
            MåleformatType_ = "double";
            AntalMålinger_ = 1;
            AnsvarstagerBrugerId_ = "NN";
            MåltagerBrugerId_ = "NN";
            Pd_.CPRNummer_ = "1234567890";
            Pd_.Fornavn_ = "N";
            Pd_.Efternavn_ = "N";
        }


        public string printMåltagerKommentar()
        {
            string output = "";

            foreach (string e in MåltagerKommentar_)
            {
                output += "" + e + "\r\n";
            }

            return output;
        }

        public string printAnsvarstagerKommentar()
        {
            string output = "";

            foreach (string e in AnsvarstagerKommentar_)
            {
                output += "" + e + "\r\n";
            }

            return output;
        }


        public string printIP()
        {
            string output = "";
            if (Ip_.Count != 0)
            {
                output += "**Autogeneret kommentar**\r\n";
                for (int i = 0; i < Ip_.Count; i++)
                {
                    output += "Interessepunkt " + (i + 1) + " ved: " + (Ip_[0] / 500) + " sekunder\r\n";
                }
                output += "*********************\r\n";
            }
            return output;
        }

    }
}
