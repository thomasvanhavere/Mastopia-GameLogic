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
        PlayerRecources Precource;
        SystemRecources Srecource;
        Farm farm;
        Harbour harbour;
        private int Ticks;
        
        private void btnvegie_Click(object sender, EventArgs e)
        {
            Precource.Vegies += Srecource.AddVegies;
            FillRecorceLbl();
        }



        private void btngrains_Click(object sender, EventArgs e)
        {
            Precource.Grains += Srecource.AddGrains;
            FillRecorceLbl();

        }

        private void btnfish_Click(object sender, EventArgs e)
        {
            Precource.Fish += Srecource.Fish;
            FillRecorceLbl();

        }

        private void btnmeat_Click(object sender, EventArgs e)
        {
            Precource.Meat += Srecource.AddMeat;
            FillRecorceLbl();

        }

        private void BtnoneH_Click(object sender, EventArgs e)
        {
            Precource.Vegies += Srecource.AddVegies;
          

            Precource.Grains += Srecource.AddGrains;
           

            Precource.Fish += Srecource.Fish;
           

            Precource.Meat += Srecource.AddMeat;
            FillRecorceLbl();
        }
        public void FillRecorceLbl()
        {
            lblvegie.Text = (Precource.Vegies + " / 100");
            lblgrains.Text = (Precource.Grains + " / 100");
            lblfish.Text = (Precource.Fish + " / 100");
            lblmeat.Text = (Precource.Meat + " / 100");
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
            Precource = new PlayerRecources();

            Srecource = new SystemRecources();
  
            farm = new Farm();
            farm.Level = 0;
            farm.TilesAvailable = 6;
            farm.GrainTile = 2;
            farm.MeatTile = 2;
            farm.VegieTile = 2;
            filllbTiles();
            harbour = new Harbour();

          
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
                Precource.Grains += farm.GrainTile;
                Precource.Vegies += farm.VegieTile;
            }
            if (Ticks%24==0)
            {
                Precource.Meat += farm.MeatTile;
            }
            if (Ticks%120==0 && harbour.UsedShips!=0)
            {
                Precource.Fish += (harbour.ShipCapacity*harbour.UsedShips);
            }
            FillRecorceLbl();

        }
    }
}
