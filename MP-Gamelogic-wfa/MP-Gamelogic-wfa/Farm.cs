using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public int TilesAvailable
        {
            get { return tileAvailable; }
            set { tileAvailable = value; }
        }
        public int FarmLevel { get; set; }
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
        public void Upgradelvl(PlayerRecources Presource)
        {
            //=100*Level
            if (Presource.Money >= (FarmLevel * 100))
            {
                FarmLevel++;
                Presource.Money -= (FarmLevel * 100);
            }
            else
            {
                MessageBox.Show("You do not Have enough moneyzzz", "No Moneyzz ??", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
