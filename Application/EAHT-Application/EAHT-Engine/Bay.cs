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
        public bool[] FindAlarms()
        {
            bool[] alarms = new bool[8] { false, false, false, false, false, false, false, false };
            foreach (Bed bed in beds)
            {
                bool[] bedalarms = bed.GetAlarms();
                if (bedalarms.Contains<bool>(true))
                {
                    alarms[bed.BedNumber - 1] = true;
                }
            }
            return alarms;
        }
    }
}
