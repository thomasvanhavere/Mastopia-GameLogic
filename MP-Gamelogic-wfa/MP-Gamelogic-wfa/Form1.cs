using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_Gamelogic_wfa
{
    public partial class frmMastopia : Form
    {

        public frmMastopia()
        {
            InitializeComponent();
        }
        PlayerRecources Presource;
        SystemRecources Srecource;
        Farm farm;
        Harbour harbour;
        Restorant resto;
        public int Ticks;
        
        private void btnvegie_Click(object sender, EventArgs e)
        {
            Presource.Vegies += Srecource.AddVegies;
            FillRecorceLbl();
        }



        private void btngrains_Click(object sender, EventArgs e)
        {
            Presource.Grains += Srecource.AddGrains;
            FillRecorceLbl();
        }

        private void btnfish_Click(object sender, EventArgs e)
        {
            Presource.Fish += Srecource.Fish;
            FillRecorceLbl();
        }

        private void btnmeat_Click(object sender, EventArgs e)
        {
            Presource.Meat += Srecource.AddMeat;
            FillRecorceLbl();
        }

        private void BtnoneH_Click(object sender, EventArgs e)
        {
            Presource.Vegies += Srecource.AddVegies;
          

            Presource.Grains += Srecource.AddGrains;
           

            Presource.Fish += Srecource.Fish;
           

            Presource.Meat += Srecource.AddMeat;
            FillRecorceLbl();
        }
        public void FillRecorceLbl()
        {
            lblvegie.Text = (Presource.Vegies + " / 100");
            lblgrains.Text = (Presource.Grains + " / 100");
            lblfish.Text = (Presource.Fish + " / 100");
            lblmeat.Text = (Presource.Meat + " / 100");
        }
        private void btnTileVegie_Click(object sender, EventArgs e)
        {
            farm.addTile(Farm.Tiles.vegie);
            filllbTiles();
        }

        private void btnTileGrain_Click(object sender, EventArgs e)
        {
            farm.addTile(Farm.Tiles.grain);
            filllbTiles();

        }

        private void btnTileMeat_Click(object sender, EventArgs e)
        {
            farm.addTile(Farm.Tiles.meat);
            filllbTiles();

        }
        public void filllbTiles()
        {
            lbTiles.Items.Clear();
            lbTiles.Items.Add("meat" + farm.MeatTile);
            lbTiles.Items.Add("grain" + farm.GrainTile);
            lbTiles.Items.Add("Vegie" + farm.VegieTile);
            lbltiles.Text = ("Tiles :" + farm.TilesAvailable);
        }

        private void frmMastopia_Load_1(object sender, EventArgs e)
        {
            Presource = new PlayerRecources();

            Srecource = new SystemRecources();
  
            farm = new Farm();
            farm.Level = 0;
            farm.TilesAvailable = 6;
            farm.GrainTile = 2;
            farm.MeatTile = 2;
            farm.VegieTile = 2;
            filllbTiles();
            harbour = new Harbour();
            resto = new Restorant();
          
        }
        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }
        private void btnRemoveTile_Click(object sender, EventArgs e)
        {
            int curItem = lbTiles.SelectedIndex;
            try
            {
                if (curItem==0)
                {
                    farm.MeatTile--;
                    farm.TilesAvailable++;
                    filllbTiles();
                }
                else if (curItem==1)
                {
                    farm.GrainTile--;
                    farm.TilesAvailable++;

                    filllbTiles();
                }
                else if (curItem==2)
                {
                    farm.VegieTile--;
                    farm.TilesAvailable++;

                    filllbTiles();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnFarmUpgrade_Click(object sender, EventArgs e)
        {

        }

        private void btnaddship_Click(object sender, EventArgs e)
        {
            if (harbour.AmountOfShips>harbour.UsedShips)
            {
                harbour.UsedShips++;
                FillShipLb();
            }
        }

        private void btnminship_Click(object sender, EventArgs e)
        {
            if (harbour.UsedShips>0)
            {
                harbour.UsedShips--;
                FillShipLb();
            }
        }
        public void FillShipLb()
        {
            lbShips.Items.Clear();
            lbShips.Items.Add("Ships in use : "+ harbour.UsedShips);
            lbShips.Items.Add(("Total Amount of ships"+ harbour.AmountOfShips));
            lblShips.Text = ("Available :"+ (harbour.AmountOfShips - harbour.UsedShips));

        }

        private void btnBuyShip_Click(object sender, EventArgs e)
        {
            harbour.AmountOfShips++;
            FillShipLb();
        }

        private void GameTime_Tick(object sender, EventArgs e)
        {
            Ticks++;
            lblGameTime.Text =("GameTime : " + Ticks);
            if (Ticks%12==0)
            {
                Presource.Grains += farm.GrainTile;
                Presource.Vegies += farm.VegieTile;
            }
            if (Ticks%24==0)
            {
                Presource.Meat += farm.MeatTile;
            }
            if (Ticks%120==0 && harbour.UsedShips!=0)
            {
                Presource.Fish += (harbour.ShipCapacity*harbour.UsedShips);
            }
           
            if (Presource.NextTick>0)
            {
                Presource.NextTick--;
            }
            FillRecorceLbl();
            FillCookList();
            ClearLists();

        }
        private void FillCookList()
        {
            ClearLists();
            lbCooking.Items.Clear();
            lbCooking.Items.Add("BBQ : " + resto.bbq.Count());
            lbCooking.Items.Add("Calamaris : " + resto.calamares.Count());
            lbCooking.Items.Add("Waffles : " + resto.waffel.Count());
            lbCooking.Items.Add("Friet : " + resto.friet.Count());
            lbCooking.Items.Add("MeatBall : " + resto.meatBall.Count());
            lbCooking.Items.Add("SimmerTrout : " + resto.simerTrout.Count());
            lbCooking.Items.Add("HerbCake : " + resto.herbCake.Count());
            lbCooking.Items.Add("FishPAsta : " + resto.fishPasta.Count());
            lbCooking.Items.Add("HotchPotch : " + resto.hotchPotch.Count());

            lbCooking.Items.Add("Total Time : " + Presource.NextTick);

        }
        private void ClearLists()
        {
            if (resto.bbq.Count() != 0)
            {
                BBQ temp = new BBQ();
                foreach (var BBQ in resto.bbq)
                {
                    if (BBQ.endTick <= Ticks)
                    {
                        temp = BBQ;
                    }
                }
                resto.bbq.Remove(temp);
            }
            if (resto.calamares.Count()!=0)
            {
                Calamares temp = new Calamares();
                foreach (var calamaris in resto.calamares)
                {
                    if (calamaris.endTick <= Ticks)
                    {
                        temp = calamaris;
                    }
                  
                }
                resto.calamares.Remove(temp);
            }
            if (resto.waffel.Count() != 0)
            {
                Waffels temp = new Waffels();
                foreach (var waffel in resto.waffel)
                {
                    if (waffel.endTick <= Ticks)
                    {
                        temp = waffel;
                    }
                }
                resto.waffel.Remove(temp);
            }
            if (resto.friet.Count() != 0)
            {
                Frieten temp = new Frieten();
                foreach (var friet in resto.friet)
                {
                    if (friet.endTick <= Ticks)
                    {
                        temp = friet;
                    }
                }
                resto.friet.Remove(temp);
            }
            if (resto.simerTrout.Count() != 0)
            {
                SimmerTrout temp = new SimmerTrout();
                foreach (var simmer in resto.simerTrout)
                {
                    if (simmer.endTick <= Ticks)
                    {
                        temp = simmer;
                    }
                }
                resto.simerTrout.Remove(temp);
            }
            if (resto.meatBall.Count() != 0)
            {
                MeatBalls temp = new MeatBalls();
                foreach (var meat in resto.meatBall)
                {
                    if (meat.endTick <= Ticks)
                    {
                        temp = meat;
                    }
                }
                resto.meatBall.Remove(temp);
            }
        }
        private void btnBBQ_Click(object sender, EventArgs e)
        {
            resto.AddBBQ(Ticks, Presource);
        }

        private void btnCalamares_Click(object sender, EventArgs e)
        {
            resto.AddCalamares(Ticks, Presource);
        }

        private void btnWaffles_Click(object sender, EventArgs e)
        {
            resto.AddWaffles(Ticks, Presource);

        }

        private void btnFrieten_Click(object sender, EventArgs e)
        {
            resto.AddFrieten(Ticks, Presource);

        }

        private void btnMeatballs_Click(object sender, EventArgs e)
        {
            resto.AddMeatBalls(Ticks, Presource);
        }

        private void btnSimmer_Click(object sender, EventArgs e)
        {
            resto.addSimmerTrout(Ticks, Presource);
        }

        private void btnHerbcake_Click(object sender, EventArgs e)
        {
            resto.AddHerbCake(Ticks, Presource);
        }

        private void btnHotchpotch_Click(object sender, EventArgs e)
        {
            resto.AddHotchPotch(Ticks, Presource);
        }

        private void btnFishPasta_Click(object sender, EventArgs e)
        {
            resto.AddFishPasta(Ticks, Presource);

        }
    }
}
