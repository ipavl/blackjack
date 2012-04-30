namespace Blackjack
{
    partial class Betting
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
            this.numBet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.cmdBet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).BeginInit();
            this.SuspendLayout();
            // 
            // numBet
            // 
            this.numBet.Location = new System.Drawing.Point(94, 31);
            this.numBet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBet.Name = "numBet";
            this.numBet.Size = new System.Drawing.Size(62, 20);
            this.numBet.TabIndex = 0;
            this.numBet.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current bet:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(47, 10);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(89, 13);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance: $500";
            // 
            // cmdBet
            // 
            this.cmdBet.Location = new System.Drawing.Point(51, 57);
            this.cmdBet.Name = "cmdBet";
            this.cmdBet.Size = new System.Drawing.Size(80, 21);
            this.cmdBet.TabIndex = 3;
            this.cmdBet.Text = "&Bet";
            this.cmdBet.UseVisualStyleBackColor = true;
            this.cmdBet.Click += new System.EventHandler(this.cmdBet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "$";
            // 
            // Betting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 89);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdBet);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Betting";
            this.Text = "Betting";
            this.Load += new System.EventHandler(this.Betting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button cmdBet;
        private System.Windows.Forms.Label label2;
    }
}