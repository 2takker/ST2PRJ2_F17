using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DB;

namespace Logik
{
    class Upload_controller
    {
        private lokalDB lokalDB_;
        private offentligDB offentligDB_;
        private List<DTO_Datasæt> datasætListe_;
        private DTO_Datasæt datasæt_;


        public Upload_controller()
        {
            lokalDB_ = new lokalDB();
            offentligDB_ = new offentligDB();
            datasætListe_ = new List<DTO_Datasæt>();
            datasæt_ = new DTO_Datasæt();
        }


        public bool indlæsCPR(string cpr)
        {
            if (lokalDB_.findCPR(cpr))
            {
                return true;
            }

            else return false;
        }
        public List<DTO_Datasæt> visSøgning(string cpr)
        {
            if (lokalDB_.findDatasæt(cpr) != null)
            {
                datasætListe_ = lokalDB_.findDatasæt(cpr);
                return datasætListe_;
            }

            else return null;
            
        }

        private void fjernPatientData(DTO_Datasæt ds)
        {
            ds.Pd_.CPRNummer_ = null;
            ds.Pd_.Fornavn_ = null;
            ds.Pd_.Efternavn_ = null;
        }
        public bool indlæsValgtDatasæt(int index, bool anonym)
        {
            //try
            //{
                datasæt_ = lokalDB_.hentDatasæt(datasætListe_[index]);
            


                if (anonym == true)
                {
                    fjernPatientData(datasæt_);
                }

                offentligDB_.gemDatasæt(datasæt_);

                return true;
            }
            //catch (Exception ex)
            //{
            //    return false;
            //}
        }
    }
}
