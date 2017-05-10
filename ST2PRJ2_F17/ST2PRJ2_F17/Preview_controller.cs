using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DTO;
using System.IO;
using System.Windows.Forms;

namespace Logik
{
    public class Preview_controller
    {
        private lokalDB lokalDB_;
        private DTO_Datasæt dtoDatasæt_;
        private List<double> dataListe_;

        public Preview_controller()
        {
            lokalDB_ = new lokalDB();
            dataListe_ = new List<double>();
            dtoDatasæt_ = new DTO_Datasæt();
        }

        public List<double> importerDatafil(Stream st)
        {
            using (var fs = st)
            using (var reader = new StreamReader(fs))
            {
              while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',', '\"');

                    dataListe_.Add(double.Parse((values[2]), System.Globalization.CultureInfo.InvariantCulture)); //Christiane                    

                    //dataListe_.Add(double.Parse((values[1]), System.Globalization.CultureInfo.InvariantCulture)); //Bjarke
                }
                dtoDatasæt_.Data_ = dataListe_;  

                return dataListe_;
            }
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
                dtoDatasæt_.Pd_ = new DTO_PatientData(cpr);
                lokalDB_.gemDatasæt(dtoDatasæt_);
                return true;
            }

            else return false;

        }

        public bool gemKommentar(string kommentar)
        {
            try
            {
                dtoDatasæt_.MåltagerKommentar_.Add(kommentar);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void indlæsBrugerId(string brugerID)
        {
            dtoDatasæt_.MåltagerBrugerId_ = brugerID;
        }
    }
}
