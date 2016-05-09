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
        private void btnvegie_Click(object sender, EventArgs e)
        {
            Precource.Vegies += Srecource.AddVegies;
            lblvegie.Text = (Precource.Vegies + " / 100");
        }



        private void btngrains_Click(object sender, EventArgs e)
        {
            Precource.Grains += Srecource.AddGrains;
            lblgrains.Text = (Precource.Grains + " / 100");

        }

        private void btnfish_Click(object sender, EventArgs e)
        {
            Precource.Fish += Srecource.Fish;
            lblfish.Text = (Precource.Fish + " / 100");

        }

        private void btnmeat_Click(object sender, EventArgs e)
        {
            Precource.Meat += Srecource.AddMeat;
            lblmeat.Text = (Precource.Meat + " / 100");

        }

        private void BtnoneH_Click(object sender, EventArgs e)
        {
            Precource.Vegies += Srecource.AddVegies;
            lblvegie.Text = (Precource.Vegies + " / 100");

            Precource.Grains += Srecource.AddGrains;
            lblgrains.Text = (Precource.Grains + " / 100");

            Precource.Fish += Srecource.Fish;
            lblfish.Text = (Precource.Fish + " / 100");

            Precource.Meat += Srecource.AddMeat;
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
    }
}
