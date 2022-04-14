using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1.Codes
{
    interface ITøj
    {
        public string TøjFarve { get; set; }
        public int SkoStørrelse { get; set; }
        public void SetSkoStørrelse(int nr);
    }
}
