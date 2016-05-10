using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_Gamelogic_wfa
{
    class Harbour
    {
        private int amountOfShips = 1;
        private int usedShips=1;
        private int shipCapacity=15;
        public int AmountOfShips
        {
            get { return amountOfShips; }
            set { amountOfShips = value; }
        }
        public int UsedShips
        {
            get { return usedShips; }
            set { usedShips = value; }
        }
        public int ShipCapacity {
            get { return shipCapacity; }
            set { shipCapacity = value; }
         }
    }
}
