using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_Gamelogic_wfa
{
    class Farm
    {
      public enum Tiles
        {
            meat,
            vegie,
            grain
        }
        private int meatTile;
        private int vegieTile;
        private int grainTile;
        private int level;
        private int tileAvailable;

        public int MeatTile
        {
            get { return meatTile; }
            set { meatTile = value; }
        }
        public int VegieTile
        {
            get { return vegieTile; }
            set { vegieTile = value; }
        }
        public int GrainTile
        {
            get { return grainTile; }
            set { grainTile = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public int TilesAvailable
        {
            get { return tileAvailable; }
            set { tileAvailable = value; }
        }
        //public int getAmountOfTiles()
        //{
        //    if (level == 0)
        //    {
        //        tileAvailable = 6;
        //        return tileAvailable;
        //    }
        //    else if (level == 1)
        //    {
        //        tileAvailable = 8;
        //        return tileAvailable;
        //    }
        //    else if (level == 2)
        //    {
        //        tileAvailable = 10;
        //        return tileAvailable;
        //    }
        //    else if (level == 3)
        //    {
        //        tileAvailable = 12;
        //        return tileAvailable;
        //    }
        //    else if (level == 4)
        //    {
        //        tileAvailable = 14;
        //        return tileAvailable;
        //    }
        //    else if (level == 5)
        //    {
        //        tileAvailable = 16;
        //        return tileAvailable;
        //    }
        //    else if (level == 6)
        //    {
        //        tileAvailable = 18;
        //        return tileAvailable;
        //    }
        //    else
        //        return 18;
        //}
        public void addTile(Tiles type)
        {
            if(type == Tiles.grain && tileAvailable!=0)
            {
                grainTile++;
                tileAvailable--;
            }
            if (type==Tiles.meat && tileAvailable != 0)
            {
                meatTile++;
                tileAvailable--;

            }
            if (type==Tiles.vegie && tileAvailable != 0)
            {
                vegieTile++;
                tileAvailable--;
                
            }
        }
    }
}
