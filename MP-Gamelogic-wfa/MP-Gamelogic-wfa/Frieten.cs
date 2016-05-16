using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_Gamelogic_wfa
{
    class Frieten : BaseFood
    {
        private  int money = 10;

        public override int Money
        {
            get { return money; }
            set { money = value; }
        }
        private int XP = 6;

        public override int Experience
        {
            get { return XP; }
            set { XP = value; }
        }
        private int waste = 1;

        public override int Waste
        {
            get { return waste; }
            set { waste = value; }
        }

        private int totalResource = 5;

        public override int TotalRecource
        {
            get { return totalResource; }
            set { totalResource = value; }
        }
        public override int endTick { get; set; }

        public Frieten(int Tick, PlayerRecources p, int restoLevel)
        {
            //Tijd =(SOM(resources)/2)*2,25
            if (p.NextTick == 0)
            {
                p.NextTick = Tick;
            }
            double Time = ((totalResource / 2) * (2.25 - (restoLevel * 0.15))) + 1;
            p.NextTick += (int)Time;
            this.endTick = (p.NextTick);

        }
        public Frieten()
        {

        }
    }
}
