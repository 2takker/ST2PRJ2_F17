using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DB;

namespace Logik
{
    public class Gennemse_data_controller
    {
        private lokalDB lokalDB_;
        private DTO_Datasæt dtoDatasæt_;
        private List<DTO_Datasæt> dtoDatasætList_;
        private DTO_PatientData dtoPD_;
        private List<double> ipListe_;
        private List<double> analyserDataListe_;

        public Gennemse_data_controller()
        {
            lokalDB_ = new lokalDB();
            dtoDatasæt_ = new DTO_Datasæt();
            dtoDatasætList_ = new List<DTO_Datasæt>();
            dtoPD_ = new DTO_PatientData();
            ipListe_ = new List<double>();
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
            return dtoDatasætList_ = lokalDB_.hentCPRData(cpr);
        }

        
        public bool analyserValgtDatasæt(int index)
        {
            dtoDatasæt_ = lokalDB_.hentDatasæt( dtoDatasætList_[index]);

            if (dtoDatasætList_[index].Ip_.Count == 0)
            {
                dtoDatasæt_.Ip_ = findRR(dtoDatasæt_.Data_);                
            }
            else
            {
                dtoDatasæt_.Ip_ = dtoDatasætList_[index].Ip_;                
            }

            return true;
        }


        public DTO_Datasæt hentAnalyseretDatasæt()
        {
            return dtoDatasæt_;
        }

        public List<double> findRR(List<double> liste)
        {
            List<double> toppunktsListeX = findToppunkt(liste);

            for (int i = 0; i < (toppunktsListeX.Count - 1); i++)
            {
                if ((toppunktsListeX[i + 1] - toppunktsListeX[i]) > 500)
                {
                    ipListe_.Add(toppunktsListeX[i]);
                }
            }
            return ipListe_;
        }

        public List<double> findToppunkt(List<double> inputListe)
        {
            List<double> toppunktsListe = new List<double>();
            double maxValue = 0;


            List<double> last10 = new List<double>();
            for (int i = 0; i < inputListe.Count; i++)
            {
                last10.Add(inputListe[i]);
                if (last10.Count > 10)
                {
                    last10.RemoveAt(0);
                }

                if (overLimit(last10, 1.0))
                {
                    if (inputListe[i] >= maxValue)
                    {
                        maxValue = inputListe[i];
                    }
                }
                else
                {
                    if (maxValue > 0)
                    {
                        toppunktsListe.Add(i);
                        maxValue = 0;
                    }
                }
            }

            return toppunktsListe;
        }

        public bool overLimit(List<double> values, double limit)
        {
            double sum = 0;
            if (values.Count < 10)
            {
                return false;
            }

            foreach (var item in values)
            {
                sum += item;
            }

            double avg = (sum / values.Count);

            if (avg > limit)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool gemKommentar(DTO_Datasæt ds)
        {
            lokalDB_.gemKommentar(ds);
            return true;
        }

         public bool gemAnalyseretData(DTO_Datasæt ds)
      {
         lokalDB_.gemIP(ds);
         return true;
      }      
    }
}
