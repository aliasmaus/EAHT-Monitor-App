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
        private List<Bed> beds = new List<Bed>();

        public Bay(int ID)
        {
            this.bayNumber = ID;
            for (int i=1; i<9; i++)
            {
                beds.Add(new Bed(i));
            }
        }

        public Bed GetBedByID(int ID)
        {
            foreach (Bed bed in beds)
            {
                if (bed.BedNumber == ID)
                {
                    return bed;
                }
            }
            throw new Exception("No bed found");
        }
    }
}
