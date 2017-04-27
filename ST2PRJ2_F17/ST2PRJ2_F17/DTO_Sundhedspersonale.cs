using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST2PRJ2_F17
{
    class DTO_Sundhedspersonale
    {
        private string brugerID_ { get; set; }
        private string kodeord_ { get; set; }

        public DTO_Sundhedspersonale(string brugerID, string kodeord)
        {
            brugerID_ = brugerID;
            kodeord_ = kodeord;
        }
        
    }
}
