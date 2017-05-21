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
        private OffentligDB offentligDB_;
        private List<DTO_Datasæt> datasætListe_;
        private DTO_Datasæt datasæt_;


        public Upload_controller()
        {
            lokalDB_ = new lokalDB();
            offentligDB_ = new OffentligDB();
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
            if (lokalDB_.hentCPRData(cpr) != null)
            {
                datasætListe_ = lokalDB_.hentCPRData(cpr);
                return datasætListe_;
            }

            else return null;

        }


        public bool indlæsValgtDatasæt(int index, bool anonym)
        {

            datasæt_ = lokalDB_.hentDatasæt(datasætListe_[index]);
            if (offentligDB_.gemDatasæt(datasæt_, anonym))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

