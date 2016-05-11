using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_Gamelogic_wfa
{
    class Restorant
    {
        public List<BBQ> bbq = new List<BBQ>();
        public List<Calamares> calamares = new List<Calamares>();
        public List<Frieten> friet = new List<Frieten>();
        public List<Waffels> waffel = new List<Waffels>();

        public List<MeatBalls> meatBall = new List<MeatBalls>();
        public List<SimmerTrout> simerTrout = new List<SimmerTrout>();
        public List<HerbCake> herbCake = new List<HerbCake>();

        public List<HotchPotch> hotchPotch = new List<HotchPotch>();
        public List<FishPasta> fishPasta = new List<FishPasta>();
        public void AddBBQ(int Tick, PlayerRecources Presource)
        {
            if (Presource.Meat>=5)
            {
                bbq.Add(new BBQ(Tick,Presource));
                Presource.Meat -= 5;
            }
        }
        public  void AddCalamares(int Tick,PlayerRecources Presource)
        {
            if (Presource.Fish>=5)
            {
                calamares.Add(new Calamares(Tick, Presource));
                Presource.Fish -= 5;
            }
        }
        public void AddFrieten(int Tick, PlayerRecources Presource)
        {
            if (Presource.Vegies >= 5)
            {
                friet.Add(new Frieten(Tick, Presource));
                Presource.Vegies -= 5;
            }
        }
        public void AddWaffles(int Tick, PlayerRecources Presource)
        {
            if (Presource.Grains >= 5)
            {
                waffel.Add(new Waffels(Tick, Presource));
                Presource.Grains -= 5;
            }
        }
        public void AddMeatBalls(int Tick, PlayerRecources Presource)
        {
            if ((Presource.Meat >= 5) && (Presource.Vegies>=5))
            {
                meatBall.Add(new MeatBalls(Tick, Presource));
                Presource.Meat -= 5;
                Presource.Vegies -= 5;
            }
        }
        public void addSimmerTrout(int Tick, PlayerRecources Presource)
        {
            if ((Presource.Fish >= 15) && (Presource.Vegies >= 10))
            {
                simerTrout.Add(new SimmerTrout(Tick, Presource));
                Presource.Fish -= 15;
                Presource.Vegies -= 10;
            }
        }
        public void AddHerbCake(int Tick, PlayerRecources Presource)
        {
            if ((Presource.Vegies >= 10) && (Presource.Grains >= 10))
            {
                herbCake.Add(new HerbCake(Tick, Presource));
                Presource.Grains -= 10;
                Presource.Vegies -= 10;
            }
        }
        public void AddHotchPotch(int Tick, PlayerRecources Presource)
        {
            if ((Presource.Meat >= 10) && (Presource.Vegies >= 8)&&(Presource.Grains>=5))
            {
                hotchPotch.Add(new HotchPotch(Tick, Presource));
                Presource.Meat -= 10;
                Presource.Vegies -= 8;
                Presource.Grains -= 5;
            }
        }
        public void AddFishPasta(int Tick, PlayerRecources Presource)
        {
            if ((Presource.Fish >= 15) && (Presource.Vegies >= 5)&&(Presource.Grains>=10))
            {
                simerTrout.Add(new SimmerTrout(Tick, Presource));
                Presource.Fish -= 15;
                Presource.Vegies -= 5;
                Presource.Grains -= 10;
            }
        }
    }
}
