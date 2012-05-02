#region File Description
//-----------------------------------------------------------------------------
// Blackjack.cs
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
    public partial class Blackjack : Form
    {
        #region "Variables"
        private int playerScore, dealerScore, rnCard, rnSuit, playerCardsCount;
        private int dScore1, dScore2, pScore1, pScore2;
        private string suit, card, dCard;
        #endregion

        #region "Controls"
        private void cmdHit_Click(object sender, EventArgs e)
        {
            DealPlayerCard();
        }

        private void cmdNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void cmdStand_Click(object sender, EventArgs e)
        {
            Stand();
        }
        #endregion

        #region "Methods"
        private void StartNewGame()
        {
            try
            {
                // Show betting interface
                Betting bettingForm = new Betting();
                bettingForm.StartPosition = FormStartPosition.CenterParent;
                bettingForm.ShowDialog();

                // Set betting labels
                lblBet.Text = "Bet: $" + Betting.Bet.ToString("#0.00");
                lblBalance.Text = "Balance: $" + Betting.Balance.ToString("#0.00");

                // Reset controls/variables for new round
                cmdHit.Enabled = true;
                cmdStand.Enabled = true;

                playerCard3.Visible = false;
                playerCard4.Visible = false;
                playerCard5.Visible = false;
                playerCard6.Visible = false;
                playerCard7.Visible = false;
                playerCard8.Visible = false;
                playerCard9.Visible = false;

                lblDealerMore.Text = "+";
                lblDealer.Visible = false;
                lblDealerMore.Visible = false;

                rnCard = 0;
                rnSuit = 0;
                playerScore = 0;
                dealerScore = 0;
                playerCardsCount = 0;

                dScore1 = 0;
                dScore2 = 0;
                pScore1 = 0;
                pScore2 = 0;

                suit = null;
                card = null;
                dCard = null;

                // Deal dealer card 1
                dScore1 = RandomNumber(1, 13);
                // Convert any face cards to appropriate number values
                ConvertFaceCardToNumberValue(dScore1);
                // Deal dealer card 2
                dScore2 = RandomNumber(1, 13);
                // Calculate dealer total
                dealerScore = dScore1 + dScore2;

                // Show dealer card 1 (backside of card)
                dealerCard1.Image = Image.FromFile("Content/Cards/back-red-75-2.png");

                // Convert any face cards to appropriate file names/number values
                ConvertFaceCardToNumberValue(dScore2);
                // Choose a random suit
                SelectSuit();
                // Show the dealer's second card
                dealerCard2.Image = Image.FromFile("Content/Cards/" + suit + "-" + card + "-75.png");
                System.Diagnostics.Debug.Print("Dealer:" + dealerScore);
                // Hide dealer's score
                lblDealer.Visible = false;
                // Set label to show dealer's score
                lblDealer.Text = "Dealer score: " + dealerScore;

                // If the dealer's score is less than 21, deal the player's cards
                if (dealerScore < 21)
                {
                    // Deal player card 1
                    DealCard();
                    pScore1 = rnCard;
                    ConvertFaceCardToNumberValue(pScore1);
                    playerCard1.Image = Image.FromFile("Content/Cards/" + dCard);
                    System.Diagnostics.Debug.Print(dCard);

                    // Deal player card 2
                    DealCard();
                    pScore2 = rnCard;
                    ConvertFaceCardToNumberValue(pScore2);
                    playerCard2.Image = Image.FromFile("Content/Cards/" + dCard);
                    System.Diagnostics.Debug.Print(dCard);

                    // Get player score and display it
                    playerScore = pScore1 + pScore2;
                    lblTotal.Text = "Score: " + playerScore;
                    playerCardsCount = 2;
                }
                else
                    GameOver("dealer21");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DealPlayerCard()
        {
            DealCard();
            playerCardsCount++;

            if (playerCardsCount == 3)
            {
                playerCard3.Image = Image.FromFile("Content/Cards/" + dCard);
                playerCard3.Visible = true;
            }
            else if (playerCardsCount == 4)
            {
                playerCard4.Image = Image.FromFile("Content/Cards/" + dCard);
                playerCard4.Visible = true;
            }
            else if (playerCardsCount == 5)
            {
                playerCard5.Image = Image.FromFile("Content/Cards/" + dCard);
                playerCard5.Visible = true;
            }
            else if (playerCardsCount == 6)
            {
                playerCard6.Image = Image.FromFile("Content/Cards/" + dCard);
                playerCard6.Visible = true;
            }
            else if (playerCardsCount == 7)
            {
                playerCard7.Image = Image.FromFile("Content/Cards/" + dCard);
                playerCard7.Visible = true;
            }
            else if (playerCardsCount == 8)
            {
                playerCard8.Image = Image.FromFile("Content/Cards/" + dCard);
                playerCard8.Visible = true;
            }
            else if (playerCardsCount == 9)
            {
                playerCard9.Image = Image.FromFile("Content/Cards/" + dCard);
                playerCard9.Visible = true;
            }
            else
            {
                GameOver("tooManyCards");
            }

            playerScore = playerScore + rnCard;
            lblTotal.Text = "Score: " + playerScore;

            if (playerScore > 21)
                GameOver("playerBust");

        }

        private void GameOver(string Condition)
        {
            bool playerWon = false;
            bool isDraw = false;
            lblDealer.Visible = true;
            cmdHit.Enabled = false;
            cmdStand.Enabled = false;

            if (Condition == "playerBust")
                MessageBox.Show("China or Bust? You just busted.", "Loss");
            else if (Condition == "dealer21")
                MessageBox.Show("The dealer's hand was 21! Game over!", "Loss");
            else if (Condition == "dealerWins")
                MessageBox.Show("Shame, the dealer's hand was higher than yours.", "Loss");
            else if (Condition == "tooManyCards")
                MessageBox.Show("Shame, you used too many cards. You lost.", "Loss");
            else if (Condition == "playerWins")
            {
                MessageBox.Show("Your hand is higher than the dealer's. You win!", "Win");
                playerWon = true;
            }
            else if (Condition == "dealerBust")
            {
                MessageBox.Show("The dealer busted. You win!", "Win");
                playerWon = true;
            }
            else if (Condition == "draw")
            {
                MessageBox.Show("You tied with the dealer.", "Draw");
                isDraw = true;
            }

            // Player won
            if (playerWon == true)
            {
                // Give the player their bet back plus 0.5x it (can't use * 1.5 here)
                Betting.Balance += (Betting.Bet * 3 / 2);
            }
            // Draw
            if (isDraw == true)
            {
                // Give the player their bet back
                Betting.Balance += Betting.Bet;
            }
        }

        private void DealCard()
        {
            rnCard = RandomNumber(1, 13);
            System.Diagnostics.Debug.Print(rnCard.ToString());
            ConvertFaceCardToNumberValue(rnCard);
            SelectSuit();
            dCard = suit + "-" + card + "-75.png";
            System.Diagnostics.Debug.Print(dCard);
        }

        private void Stand()
        {
            // Disable player controls
            cmdStand.Enabled = false;
            cmdHit.Enabled = false;
            // Show dealer score
            lblDealer.Visible = true;
            lblDealer.Text = "Dealer score: " + dealerScore;

            ConvertFaceCardToNumberValue(dScore1);

            dealerCard1.Image = Image.FromFile("Content/Cards/diamonds-" + card + "-75.png");
            if (dealerScore < 17)
            {
                DealCard();
                dealerScore = dealerScore + rnCard;
                lblDealerMore.Text = lblDealerMore.Text + " " + rnCard;
                lblDealerMore.Visible = true;
                Stand();
            }
            else if (dealerScore > 17 && dealerScore <= 21 && dealerScore > playerScore)
                GameOver("dealerWins");
            else if (dealerScore > 21)
                GameOver("dealerBust");
            else if (playerScore > dealerScore)
                GameOver("playerWins");
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void ConvertFaceCardToNumberValue(int FaceCard)
        {
            // If the card is a "face card", convert its number to a letter and its value to >10
            if (FaceCard == 1)
                card = "a";
            else if (FaceCard == 11)
            {
                card = "j";
                FaceCard = 10;
            }
            else if (FaceCard == 12)
            {
                card = "q";
                FaceCard = 10;
            }
            else if (FaceCard == 13)
            {
                card = "k";
                FaceCard = 10;
            }
            else
                card = FaceCard.ToString();
        }

        private string SelectSuit()
        {
            // Choose a random suit
            rnSuit = RandomNumber(1, 4);
            if (rnSuit == 1)
                suit = "clubs";
            else if (rnSuit == 2)
                suit = "diamonds";
            else if (rnSuit == 3)
                suit = "hearts";
            else if (rnSuit == 4)
                suit = "spades";

            return suit;
        }
        #endregion

        private void Blackjack_Load(object sender, EventArgs e)
        {
            this.Text = "Blackjack v0.1.5_02 by Ian P (ippavlin)";
            StartNewGame();
        }

        public Blackjack()
        {
            InitializeComponent();
        }
    }
}
