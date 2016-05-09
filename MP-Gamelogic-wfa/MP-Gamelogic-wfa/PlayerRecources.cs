using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_Gamelogic_wfa
{
    class PlayerRecources
    {
        private int vegies;
        private int meat;
        private int grains;
        private int fish;
        public int Vegies
        {
            get { return vegies; }
            set { vegies = value; }
        }
        public int Meat
        {
            get { return meat; }
            set { meat = value; }
        }
        public int Grains
        {
            get { return grains; }
            set { grains = value; }
        }
        public int Fish
        {
            get { return fish; }
            set { fish = value; }
        }
    }
}
