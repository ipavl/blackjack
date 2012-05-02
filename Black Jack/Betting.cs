#region File Description
//-----------------------------------------------------------------------------
// Betting.cs
//
// April 2012
// Copyright (C) Ian P (ippavlin). All rights reserved.
//-----------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Betting : Form
    {
        public static decimal Bet = 50;
        public static decimal Balance = 500;

        public Betting()
        {
            InitializeComponent();
        }

        private void Betting_Load(object sender, EventArgs e)
        {
            lblBalance.Text = "Balance: $" + Balance.ToString("#0.00");
        }

        private void cmdBet_Click(object sender, EventArgs e)
        {
            Bet = numBet.Value;
            if (Balance == 0)
            {
                MessageBox.Show(null, "Sorry, you are out of money to bet with!", 
                    "Say Good-bye to Vegas!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            else if (Bet > Balance)
                MessageBox.Show("Sorry, you do not have $" + Bet + " to bet. " +
                   "Please choose a lower amount.", "Bet too high");
            else
            {
                Balance -= Bet;
                lblBalance.Text = "Balance: $" + Balance.ToString();
                this.Close();
            }
        }
    }
}
