using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_Gamelogic_wfa
{
    class SystemRecources
    {
        private int vegies = 5;
        private int meat = 5;
        private int grains = 5;
        private int fish = 15;
        public int AddVegies
        {
            get { return vegies; }
            set { vegies = value; }
        }
        public int AddMeat
        {
            get { return meat; }
            set { meat = value; }
        }
        public int AddGrains
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
