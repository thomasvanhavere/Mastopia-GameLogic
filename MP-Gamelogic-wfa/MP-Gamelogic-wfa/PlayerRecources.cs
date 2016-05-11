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
        private int playerLevel = 0;

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
        public int Money { get; set; }
        public int XP { get; set; }

        public int NextTick { get; set; }


        public int PLayerLevel
        {
            get { return playerLevel ; }
            set { playerLevel  = value; }
        }
        private int nextLevel = 100;

        public int NextLevel
        {
            get { return nextLevel; }
            set { nextLevel = value; }
        }
        

        public void CheckLevel()
        {
            // y = 100(1 + 0.26) ^ x
          
                   
            if (XP>=nextLevel)
            {
                playerLevel++;
                double next = (100 * Math.Pow((double)(1 + 0.26), (double)playerLevel));
                nextLevel += (int)next;
               
                
            }
        }

    }
}
