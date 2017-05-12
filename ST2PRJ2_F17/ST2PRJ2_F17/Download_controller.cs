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
        private OffentligDB offentligDB_;
        private List<DTO_Datasæt> datasætListe_;
        private DTO_Datasæt datasæt_;
        public Download_controller()
        {
            lokalDB_ = new lokalDB();
            offentligDB_ = new OffentligDB();
            datasætListe_ = new List<DTO_Datasæt>();
            datasæt_ = new DTO_Datasæt();
        }

        public List<DTO_Datasæt> visSøgning(string søgeord)
        {          
            return datasætListe_ = offentligDB_.søgIOffDB(søgeord);
        }

        public bool indlæsValgtDatasæt(int index)
        {
            try
            {
                datasæt_ = offentligDB_.downloadDataFraOffDB(datasætListe_[index]);
                lokalDB_.gemDatasæt(datasæt_);

                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
