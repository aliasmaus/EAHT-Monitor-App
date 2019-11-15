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

        public Bay(int ID)
        {
            this.beds = new Bed[Options.BedsPerBay];
            this.bayNumber = ID;
            for (int i=0; i<beds.Length; i++)
            {
                beds[i] = new Bed(i+1);
            }
        }

    }
}
