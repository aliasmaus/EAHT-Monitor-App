using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAHT_Engine
{
    public class Bay
    {
        private int bayNumber;
        private Bed[] beds;

        public Bed[] Beds { get => beds; }

        public Bay(int ID, int nBeds, int nMonitors)
        {
            this.beds = new Bed[nBeds];
            this.bayNumber = ID;
            for (int bed=0; bed<beds.Length; bed++)
            {
                beds[bed] = new Bed(bed+1,nMonitors);
            }
        }

    }
}
