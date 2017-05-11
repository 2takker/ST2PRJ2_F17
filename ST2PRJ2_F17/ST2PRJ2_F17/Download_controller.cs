using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DB;

namespace Logik
{
    class Download_controller
    {
        private lokalDB lokalDB_;
        private offentligDB offentligDB_;
        private List<DTO_Datasæt> datasætListe_;
        private DTO_Datasæt datasæt_;
        public Download_controller()
        {
            lokalDB_ = new lokalDB();
            offentligDB_ = new offentligDB();
            datasætListe_ = new List<DTO_Datasæt>();
            datasæt_ = new DTO_Datasæt();
        }

        public List<DTO_Datasæt> visSøgning(string søgeord)
        {          
            return datasætListe_ = offentligDB_.søgIOffDB(søgeord);
        }

        public DTO_Datasæt indlæsValgtDatasæt(int index)
        {
            datasæt_ = offentligDB_.hentDSFraOffDB(datasætListe_[index]);

            return datasæt_;
        }
    }
}
