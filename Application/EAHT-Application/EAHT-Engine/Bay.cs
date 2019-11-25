using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAHT_Engine
{
    /// <summary>
    /// Bays contain beds
    /// </summary>
    public class Bay
    {
        private readonly int bayNumber;
        private readonly Bed[] beds;
        private readonly Ward wardRef;

        public Bed[] Beds { get => beds; }

        public Bay(int ID, int nBeds, int nMonitors, Ward ward)
        {
            this.beds = new Bed[nBeds];
            this.bayNumber = ID;
            this.wardRef = ward;
            for (int bed=0; bed<nBeds; bed++)
            {
                beds[bed] = new Bed(bed,nMonitors,ward);
            }
        }

    }
}
