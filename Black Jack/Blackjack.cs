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
using System.Diagnostics;

namespace Blackjack
{
    public partial class Blackjack : Form
    {
        #region "Variables"
        private int playerScore, dealerScore, rnCard, rnSuit, playerCardsCount, cardValue;
        private int dScore1, dScore2, pScore1, pScore2;
        private string suit, card, dCard;
        private bool isGameOver;
        #endregion

        #region "Controls"
        private void cmdNewGame_Click(object sender, EventArgs e)
        {
            if (isGameOver)
                StartNewGame();
            else
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
                    StartNewGame();
                }
            }
        }

        private void cmdHit_Click(object sender, EventArgs e)
        {
            DealPlayerCard();
        }

        private void cmdStand_Click(object sender, EventArgs e)
        {
            Stand();
        }

        private void cmdDoubleDown_Click(object sender, EventArgs e)
        {
            DoubleDown();
        }

        private void cmdSplit_Click(object sender, EventArgs e)
        {

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
                cmdDoubleDown.Enabled = true;
                cmdSplit.Enabled = false;

                isGameOver = false;
                cmdNewGame.Text = "Surrender";

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
                Debug.Print("Dealer card 1: " + dScore1.ToString());
                // Convert any face cards to appropriate number values
                ConvertFaceCardToNumberValue(dScore1);
                dScore1 = cardValue;
                Debug.Print("dScore1 -> Num: " + dScore1);
                // Deal dealer card 2
                dScore2 = RandomNumber(1, 13);
                Debug.Print("Dealer card 2: " + dScore2.ToString());
                // Convert any face cards to appropriate number values
                ConvertFaceCardToNumberValue(dScore2);
                dScore2 = cardValue;
                ConvertFaceCardToFileName(dScore2);
                Debug.Print("dScore2 -> Num: " + dScore2);
                // Calculate dealer total
                dealerScore = dScore1 + dScore2;

                // Show dealer card 1 (backside of card)
                dealerCard1.Image = Image.FromFile("Content/Cards/back-red-75-2.png");

                // Choose a random suit
                SelectSuit();
                // Show the dealer's second card
                dealerCard2.Image = Image.FromFile("Content/Cards/" + suit + "-" +
                    card + "-75.png");
                Debug.Print("dealerScore: " + dealerScore);
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
                    pScore1 = cardValue;
                    playerCard1.Image = Image.FromFile("Content/Cards/" + dCard);
                    Debug.Print("Player card 1: " + dCard);

                    // Deal player card 2
                    DealCard();
                    pScore2 = rnCard;
                    ConvertFaceCardToNumberValue(pScore2);
                    pScore2 = cardValue;
                    playerCard2.Image = Image.FromFile("Content/Cards/" + dCard);
                    Debug.Print("Player card 2: " + dCard);

                    // Split
                    if (pScore1 == pScore2 && playerCardsCount == 2)
                    {
                        cmdSplit.Enabled = true;
                    }

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
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void DealCard()
        {
            rnCard = RandomNumber(1, 13);
            Debug.Print("DealCard (rnCard): " + rnCard.ToString());
            ConvertFaceCardToFileName(rnCard);
            Debug.Print("DealCard (rnCard->Face): " + card);
            ConvertFaceCardToNumberValue(rnCard);
            Debug.Print("DealCard (rnCard->Num): " + cardValue);
            SelectSuit();
            dCard = suit + "-" + card + "-75.png";
            Debug.Print("DealCard (dCard): " + dCard);
        }

        private void DealPlayerCard()
        {
            DealCard();
            playerCardsCount++;
            cmdDoubleDown.Enabled = false;

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

            playerScore += cardValue;
            lblTotal.Text = "Score: " + playerScore;

            if (playerScore > 21)
                GameOver("playerBust");

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
            dScore1 = cardValue;
            ConvertFaceCardToFileName(dScore1);
            SelectSuit();

            dealerCard1.Image = Image.FromFile("Content/Cards/" + suit +
                "-" + card + "-75.png");

            if (dealerScore < 17 && dealerScore <= 21)
            {
                DealCard();
                dealerScore += rnCard;
                lblDealerMore.Text = lblDealerMore.Text + " " + rnCard;
                lblDealerMore.Visible = true;
                Stand();
            }
            if (isGameOver == false)
            {
                if (dealerScore > 17 && dealerScore <= 21 && dealerScore > playerScore)
                    GameOver("dealerWins");
                else if (dealerScore > 21)
                    GameOver("dealerBust");
                else if (playerScore > dealerScore)
                    GameOver("playerWins");
                else if (playerScore == dealerScore)
                    GameOver("draw");
            }
        }

        private void DoubleDown()
        {
            bool DoubleDown = false;
            if (playerCardsCount == 2)
            {
                if (Betting.Bet < Betting.Balance && Betting.Balance > 0)
                {
                    // Take another "bet" of the same amount from the player
                    Betting.Balance -= Betting.Bet;
                    // Double the player's bet
                    Betting.Bet *= 2;
                    DoubleDown = true;
                }
                else if (Betting.Bet > Betting.Balance && Betting.Balance > 0)
                {
                    // All in
                    Betting.Bet += Betting.Balance;
                    Betting.Balance -= Betting.Balance;
                    DoubleDown = true;
                }
                else
                    MessageBox.Show("You cannot afford to double-down.", "Blackjack");

                if (DoubleDown == true)
                {
                    // Set betting labels
                    lblBet.Text = "Bet: $" + Betting.Bet.ToString("#0.00");
                    lblBalance.Text = "Balance: $" + Betting.Balance.ToString("#0.00");
                    // Deal the player a card
                    DealPlayerCard();
                    // Disable double-down button
                    cmdDoubleDown.Enabled = false;
                    DoubleDown = false;
                    // Force the player to stand
                    Stand();
                }
            }
            else
                MessageBox.Show("You cannot double-down with more than 2 cards.", "Blackjack");
        }

        private void GameOver(string Condition)
        {
            bool playerWon = false;
            bool isDraw = false;

            lblDealer.Visible = true;
            cmdHit.Enabled = false;
            cmdStand.Enabled = false;
            cmdDoubleDown.Enabled = false;
            cmdSplit.Enabled = false;

            isGameOver = true;
            cmdNewGame.Text = "New Game";

            // Convert number value to letter for file name purposes
            ConvertFaceCardToFileName(dScore1);
            // Choose a random suit
            SelectSuit();
            // Show the dealer's first card
            dealerCard1.Image = Image.FromFile("Content/Cards/" + suit + "-" + card + "-75.png");

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

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private int ConvertFaceCardToNumberValue(int FaceCard)
        {
            // If the card is a "face card", convert its value to 10
            if (FaceCard == 11 || FaceCard == 12 || FaceCard == 13)
                cardValue = 10;
            else
                cardValue = FaceCard;

            return cardValue;
        }

        private string ConvertFaceCardToFileName(int FaceCard)
        {
            // If the card is a "face card", convert the integer to a letter for file names
            if (FaceCard == 1)
                card = "a";
            else if (FaceCard == 11)
                card = "j";
            else if (FaceCard == 12)
                card = "q";
            else if (FaceCard == 13)
                card = "k";
            else
                card = FaceCard.ToString();

            return card;
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
            this.Text = "Blackjack v0.1.8 by Ian P (ippavlin)";
            StartNewGame();
        }

        public Blackjack()
        {
            InitializeComponent();
        }
    }
}
