using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_Gamelogic_wfa
{
    class FishPasta
    {
        private int money = 60;

        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        private int XP = 38;

        public int Experience
        {
            get { return XP; }
            set { XP = value; }
        }
        private int waste = 3;

        public int Waste
        {
            get { return waste; }
            set { waste = value; }
        }


        public int endTick { get; set; }

        public FishPasta(int Tick, PlayerRecources p)
        {
            if (p.NextTick == 0)
            {
                p.NextTick = Tick;
            }
            p.NextTick += 34;
            this.endTick = (p.NextTick);

        }
        public FishPasta()
        {

        }
    }
}
