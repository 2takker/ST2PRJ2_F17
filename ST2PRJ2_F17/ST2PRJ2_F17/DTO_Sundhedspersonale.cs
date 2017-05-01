using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Sundhedspersonale
    {
        public string BrugerID_ { get; set; }
        public string Kodeord_ { get; set; }

        public DTO_Sundhedspersonale(string brugerID, string kodeord)
        {
            BrugerID_ = brugerID;
            Kodeord_ = kodeord;
        }

    }
}
