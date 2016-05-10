using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_Gamelogic_wfa
{
    class BBQ
    {
        private int money = 10;

        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        private int XP=6;

        public int Experience
        {
            get { return XP; }
            set { XP = value; }
        }
        private int waste = 1;

        public int Waste
        {
            get { return waste; }
            set { waste = value; }
        }
        

        public int endTick { get; set; }

        public BBQ(int Tick, PlayerRecources p)
        {
            if (p.NextTick==0)
            {
                p.NextTick = Tick;
            }
            p.NextTick += 6;
            this.endTick = (p.NextTick);
          
        }
        public BBQ()
        {

        }
    }
}
