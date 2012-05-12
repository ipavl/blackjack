#region File Description
//-----------------------------------------------------------------------------
// Split.cs
//
// May 2012
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
using System.Diagnostics;

namespace Blackjack
{
    public partial class Split : Form
    {
        #region "Variables"
        public static decimal Bet1, Bet2;
        #endregion

        #region "Controls"
        private void cmdNewGame_Click(object sender, EventArgs e)
        {
            if (!Blackjack.isGameOver)
            {
                // Surrender
                DialogResult dialogResult = MessageBox.Show(null, "Are you sure you " +
                    "want to surrender? You will receive half of your bet back and this " +
                    "round will count as a loss.", "Surrender?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    // Give the player half their bet back
                    Betting.Balance += (Betting.Bet / 2);
                }
            }
            // We'll use this to return to the main form and the player can click New Game there
            this.Close();
        }
        #endregion

        private void Split_Load(object sender, EventArgs e)
        {
            // Clone cards from other form
            dealerCard2.Image = Image.FromFile("Content/Cards/" + Blackjack.DealerSecondCard);
            playerCard1.Image = Image.FromFile("Content/Cards/" + Blackjack.PlayerFirstCard);
            playerCard2.Image = Image.FromFile("Content/Cards/" + Blackjack.PlayerSecondCard);

            // Split the existing bet between the two hands
            Bet1 = Betting.Bet / 2;
            Bet2 = Betting.Bet / 2;
            lblBet1.Text = Bet1.ToString("$0.00");
            lblBet2.Text = Bet2.ToString("$0.00");
            lblBalance.Text = Betting.Balance.ToString("$0.00");

            // Update totals
            lblHand1Total.Text = "Total: " + Blackjack.pScore1.ToString();
            lblHand2Total.Text = "Total: " + Blackjack.pScore2.ToString();
        }

        public Split()
        {
            InitializeComponent();
        }

        private void cmdHit_Click(object sender, EventArgs e)
        {

        }
    }
}
