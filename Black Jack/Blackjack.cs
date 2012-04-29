using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Black_Jack
{
    public partial class Blackjack : Form
    {
        private int playerScore, dealerScore, rnCard, rnSuit, playerCardsCount;
        private int dScore1, dScore2, pScore1, pScore2;
        private string suit, card, dCard;

        public Blackjack()
        {
            InitializeComponent();
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void DealCard()
        {
            rnCard = RandomNumber(1, 13);
            System.Diagnostics.Debug.Print(rnCard.ToString());
            rnSuit = RandomNumber(1, 4);
            System.Diagnostics.Debug.Print(rnSuit.ToString());

            if (rnCard == 1)
                card = "a";
            else if (rnCard == 11)
                card = "j";
            else if (rnCard == 12)
                card = "q";
            else if (rnCard == 13)
                card = "k";
            else
                card = rnCard.ToString();

            if (rnSuit == 1)
                suit = "clubs";
            else if (rnSuit == 2)
                suit = "diamonds";
            else if (rnSuit == 3)
                suit = "hearts";
            else if (rnSuit == 4)
                suit = "spades";
            else
                suit = null;

            dCard = suit + "-" + card + "-75.png";
            System.Diagnostics.Debug.Print(dCard);
        }

        private void cmdHit_Click(object sender, EventArgs e)
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
                GameOver();
            }

            playerScore = playerScore + rnCard;
            lblTotal.Text = "Score: " + playerScore;

            if (playerScore > 21)
                GameOver();
        }

        private void GameOver()
        {
            if (dealerScore > playerScore)
                MessageBox.Show("Shame, the dealer's hand was higher than yours.", "Game over");
            else if (playerScore > 21)
                MessageBox.Show("China or Bust? You just busted.", "Game over");
            else if (playerCardsCount == 10)
                MessageBox.Show("Shame, you used too many cards. You lost.", "Game over");
            else if (dealerScore < playerScore)
                MessageBox.Show("You won!", "Game over");
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {
            dScore1 = RandomNumber(1, 13);
            dScore2 = RandomNumber(1, 13);
            dealerScore = dScore1 + dScore2;

            dealerCard1.Image = Image.FromFile("Content/Cards/back-red-75-2.png");
            
            if (rnCard == 1)
                card = "a";
            else if (rnCard == 11)
                card = "j";
            else if (rnCard == 12)
                card = "q";
            else if (rnCard == 13)
                card = "k";

            dealerCard2.Image = Image.FromFile("Content/Cards/spades-" + dScore2 + "-75.png");

            System.Diagnostics.Debug.Print("Dealer:" + dealerScore);
            lblDealer.Visible = false;
            lblDealer.Text = "Dealer score: " + dealerScore;

            if (dealerScore < 21)
            {
                DealCard();
                pScore1 = rnCard;
                playerCard1.Image = Image.FromFile("Content/Cards/" + dCard);
                DealCard();
                pScore2 = rnCard;
                playerCard2.Image = Image.FromFile("Content/Cards/" + dCard);
                playerScore = pScore1 + pScore2;
                lblTotal.Text = "Score: " + playerScore;
                playerCardsCount = 2;
            }
            else
                MessageBox.Show("The dealer's hand was 21! Game over!", "You lose!");
        }

        private void pStand()
        {
            lblDealer.Visible = true;
            lblDealer.Text = "Dealer score: " + dealerScore;

            if (dScore1 == 1)
                card = "a";
            else if (dScore1 == 11)
                card = "j";
            else if (dScore1 == 12)
                card = "q";
            else if (dScore1 == 13)
                card = "k";

            dealerCard1.Image = Image.FromFile("Content/Cards/diamonds-" + dScore1 + "-75.png");
            if (dealerScore < 17)
            {
                DealCard();
                dealerScore = dealerScore + rnCard;
                lblDealerMore.Text = lblDealerMore.Text + " " + rnCard;
                lblDealerMore.Visible = true;
                pStand();
            }
            else if (dealerScore > 17 && dealerScore <= 21)
            {
                GameOver();
            }
            else if (dealerScore > 21)
            {
                MessageBox.Show("You win! The dealer busted.", "Win!");
            }
        }

        private void cmdStand_Click(object sender, EventArgs e)
        {
            cmdStand.Enabled = false;
            cmdHit.Enabled = false;
            pStand();
        }
    }
}
