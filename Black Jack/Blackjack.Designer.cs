namespace Blackjack
{
    partial class Blackjack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blackjack));
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmdStand = new System.Windows.Forms.Button();
            this.cmdHit = new System.Windows.Forms.Button();
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDealerMore = new System.Windows.Forms.Label();
            this.dealerCard2 = new System.Windows.Forms.PictureBox();
            this.dealerCard1 = new System.Windows.Forms.PictureBox();
            this.lblDealer = new System.Windows.Forms.Label();
            this.playerCard3 = new System.Windows.Forms.PictureBox();
            this.playerCard4 = new System.Windows.Forms.PictureBox();
            this.playerCard5 = new System.Windows.Forms.PictureBox();
            this.playerCard6 = new System.Windows.Forms.PictureBox();
            this.playerCard7 = new System.Windows.Forms.PictureBox();
            this.playerCard8 = new System.Windows.Forms.PictureBox();
            this.playerCard9 = new System.Windows.Forms.PictureBox();
            this.cmdNewGame = new System.Windows.Forms.Button();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard9)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.BackColor = System.Drawing.Color.Transparent;
            this.grpOptions.Controls.Add(this.lblBet);
            this.grpOptions.Controls.Add(this.lblTotal);
            this.grpOptions.Controls.Add(this.cmdStand);
            this.grpOptions.Controls.Add(this.cmdHit);
            this.grpOptions.ForeColor = System.Drawing.Color.Lime;
            this.grpOptions.Location = new System.Drawing.Point(303, 322);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(223, 107);
            this.grpOptions.TabIndex = 4;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.Transparent;
            this.lblBet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblBet.Location = new System.Drawing.Point(6, 86);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(47, 13);
            this.lblBet.TabIndex = 7;
            this.lblBet.Text = "Bet: $$$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotal.Location = new System.Drawing.Point(166, 86);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total: ##";
            // 
            // cmdStand
            // 
            this.cmdStand.ForeColor = System.Drawing.Color.Black;
            this.cmdStand.Location = new System.Drawing.Point(22, 54);
            this.cmdStand.Name = "cmdStand";
            this.cmdStand.Size = new System.Drawing.Size(175, 29);
            this.cmdStand.TabIndex = 5;
            this.cmdStand.Text = "I\'ll &Stand";
            this.cmdStand.UseVisualStyleBackColor = true;
            this.cmdStand.Click += new System.EventHandler(this.cmdStand_Click);
            // 
            // cmdHit
            // 
            this.cmdHit.ForeColor = System.Drawing.Color.Black;
            this.cmdHit.Location = new System.Drawing.Point(22, 19);
            this.cmdHit.Name = "cmdHit";
            this.cmdHit.Size = new System.Drawing.Size(175, 29);
            this.cmdHit.TabIndex = 4;
            this.cmdHit.Text = "&Hit Me!";
            this.cmdHit.UseVisualStyleBackColor = true;
            this.cmdHit.Click += new System.EventHandler(this.cmdHit_Click);
            // 
            // playerCard1
            // 
            this.playerCard1.BackColor = System.Drawing.Color.Transparent;
            this.playerCard1.Location = new System.Drawing.Point(113, 322);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(75, 107);
            this.playerCard1.TabIndex = 0;
            this.playerCard1.TabStop = false;
            // 
            // playerCard2
            // 
            this.playerCard2.BackColor = System.Drawing.Color.Transparent;
            this.playerCard2.Location = new System.Drawing.Point(205, 322);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(75, 107);
            this.playerCard2.TabIndex = 5;
            this.playerCard2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblDealerMore);
            this.groupBox1.Controls.Add(this.dealerCard2);
            this.groupBox1.Controls.Add(this.dealerCard1);
            this.groupBox1.Controls.Add(this.lblDealer);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(132, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dealer";
            // 
            // lblDealerMore
            // 
            this.lblDealerMore.AutoSize = true;
            this.lblDealerMore.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerMore.ForeColor = System.Drawing.Color.Yellow;
            this.lblDealerMore.Location = new System.Drawing.Point(203, 97);
            this.lblDealerMore.Name = "lblDealerMore";
            this.lblDealerMore.Size = new System.Drawing.Size(21, 24);
            this.lblDealerMore.TabIndex = 9;
            this.lblDealerMore.Text = "+";
            this.lblDealerMore.Visible = false;
            // 
            // dealerCard2
            // 
            this.dealerCard2.BackColor = System.Drawing.Color.Transparent;
            this.dealerCard2.Location = new System.Drawing.Point(116, 14);
            this.dealerCard2.Name = "dealerCard2";
            this.dealerCard2.Size = new System.Drawing.Size(75, 107);
            this.dealerCard2.TabIndex = 8;
            this.dealerCard2.TabStop = false;
            // 
            // dealerCard1
            // 
            this.dealerCard1.BackColor = System.Drawing.Color.Transparent;
            this.dealerCard1.Location = new System.Drawing.Point(35, 14);
            this.dealerCard1.Name = "dealerCard1";
            this.dealerCard1.Size = new System.Drawing.Size(75, 107);
            this.dealerCard1.TabIndex = 7;
            this.dealerCard1.TabStop = false;
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.BackColor = System.Drawing.Color.Transparent;
            this.lblDealer.Font = new System.Drawing.Font("Pescadero", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(203, 52);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(136, 23);
            this.lblDealer.TabIndex = 6;
            this.lblDealer.Text = "Dealer Total: #";
            // 
            // playerCard3
            // 
            this.playerCard3.BackColor = System.Drawing.Color.Transparent;
            this.playerCard3.Location = new System.Drawing.Point(39, 195);
            this.playerCard3.Name = "playerCard3";
            this.playerCard3.Size = new System.Drawing.Size(75, 107);
            this.playerCard3.TabIndex = 7;
            this.playerCard3.TabStop = false;
            this.playerCard3.Visible = false;
            // 
            // playerCard4
            // 
            this.playerCard4.BackColor = System.Drawing.Color.Transparent;
            this.playerCard4.Location = new System.Drawing.Point(120, 195);
            this.playerCard4.Name = "playerCard4";
            this.playerCard4.Size = new System.Drawing.Size(75, 107);
            this.playerCard4.TabIndex = 8;
            this.playerCard4.TabStop = false;
            this.playerCard4.Visible = false;
            // 
            // playerCard5
            // 
            this.playerCard5.BackColor = System.Drawing.Color.Transparent;
            this.playerCard5.Location = new System.Drawing.Point(201, 195);
            this.playerCard5.Name = "playerCard5";
            this.playerCard5.Size = new System.Drawing.Size(75, 107);
            this.playerCard5.TabIndex = 9;
            this.playerCard5.TabStop = false;
            this.playerCard5.Visible = false;
            // 
            // playerCard6
            // 
            this.playerCard6.BackColor = System.Drawing.Color.Transparent;
            this.playerCard6.Location = new System.Drawing.Point(282, 195);
            this.playerCard6.Name = "playerCard6";
            this.playerCard6.Size = new System.Drawing.Size(75, 107);
            this.playerCard6.TabIndex = 10;
            this.playerCard6.TabStop = false;
            this.playerCard6.Visible = false;
            // 
            // playerCard7
            // 
            this.playerCard7.BackColor = System.Drawing.Color.Transparent;
            this.playerCard7.Location = new System.Drawing.Point(363, 195);
            this.playerCard7.Name = "playerCard7";
            this.playerCard7.Size = new System.Drawing.Size(75, 107);
            this.playerCard7.TabIndex = 11;
            this.playerCard7.TabStop = false;
            this.playerCard7.Visible = false;
            // 
            // playerCard8
            // 
            this.playerCard8.BackColor = System.Drawing.Color.Transparent;
            this.playerCard8.Location = new System.Drawing.Point(444, 195);
            this.playerCard8.Name = "playerCard8";
            this.playerCard8.Size = new System.Drawing.Size(75, 107);
            this.playerCard8.TabIndex = 12;
            this.playerCard8.TabStop = false;
            this.playerCard8.Visible = false;
            // 
            // playerCard9
            // 
            this.playerCard9.BackColor = System.Drawing.Color.Transparent;
            this.playerCard9.Location = new System.Drawing.Point(525, 195);
            this.playerCard9.Name = "playerCard9";
            this.playerCard9.Size = new System.Drawing.Size(75, 107);
            this.playerCard9.TabIndex = 13;
            this.playerCard9.TabStop = false;
            this.playerCard9.Visible = false;
            // 
            // cmdNewGame
            // 
            this.cmdNewGame.Location = new System.Drawing.Point(0, 0);
            this.cmdNewGame.Name = "cmdNewGame";
            this.cmdNewGame.Size = new System.Drawing.Size(68, 20);
            this.cmdNewGame.TabIndex = 14;
            this.cmdNewGame.Text = "New Game";
            this.cmdNewGame.UseVisualStyleBackColor = true;
            this.cmdNewGame.Click += new System.EventHandler(this.cmdNewGame_Click);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(639, 467);
            this.Controls.Add(this.cmdNewGame);
            this.Controls.Add(this.playerCard9);
            this.Controls.Add(this.playerCard8);
            this.Controls.Add(this.playerCard7);
            this.Controls.Add(this.playerCard6);
            this.Controls.Add(this.playerCard5);
            this.Controls.Add(this.playerCard4);
            this.Controls.Add(this.playerCard3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.grpOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Blackjack";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Blackjack_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button cmdStand;
        private System.Windows.Forms.Button cmdHit;
        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.PictureBox playerCard2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox dealerCard2;
        private System.Windows.Forms.PictureBox dealerCard1;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.PictureBox playerCard3;
        private System.Windows.Forms.PictureBox playerCard4;
        private System.Windows.Forms.PictureBox playerCard5;
        private System.Windows.Forms.PictureBox playerCard6;
        private System.Windows.Forms.PictureBox playerCard7;
        private System.Windows.Forms.PictureBox playerCard8;
        private System.Windows.Forms.PictureBox playerCard9;
        private System.Windows.Forms.Label lblDealerMore;
        private System.Windows.Forms.Button cmdNewGame;
        private System.Windows.Forms.Label lblBet;
    }
}

