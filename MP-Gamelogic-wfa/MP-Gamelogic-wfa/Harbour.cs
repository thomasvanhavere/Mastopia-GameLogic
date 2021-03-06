﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_Gamelogic_wfa
{
    class Harbour
    {
        private int amountOfShips = 1;
        private int usedShips=1;
        private int shipCapacity=15;
        public int AmountOfShips
        {
            get { return amountOfShips; }
            set { amountOfShips = value; }
        }
        public int UsedShips
        {
            get { return usedShips; }
            set { usedShips = value; }
        }
        public int ShipCapacity {
            get { return shipCapacity; }
            set { shipCapacity = value; }
         }
        public int HarbourLevel { get; set; }
        public void Upgradelvl(PlayerRecources Presource)
        {
            //=90*Level
            if (Presource.Money >= (HarbourLevel * 90))
            {
                HarbourLevel++;
                Presource.Money -= (HarbourLevel * 90);
            }
            else
            {
                MessageBox.Show("You do not Have enough moneyzzz", "No Moneyzz ??", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
