namespace BettingHouse_TheGame
{
    partial class Form1
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
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DogNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BetAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.BettorName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinimumBet = new System.Windows.Forms.Label();
            this.arekButton = new System.Windows.Forms.RadioButton();
            this.bartekButton = new System.Windows.Forms.RadioButton();
            this.janekButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.janekBet = new System.Windows.Forms.Label();
            this.bartekBet = new System.Windows.Forms.Label();
            this.arekBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrack
            // 
            this.racetrack.Image = global::BettingHouse_TheGame.Properties.Resources.racetrack;
            this.racetrack.Location = new System.Drawing.Point(12, 12);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(602, 200);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arekBet);
            this.groupBox1.Controls.Add(this.bartekBet);
            this.groupBox1.Controls.Add(this.janekBet);
            this.groupBox1.Controls.Add(this.DogNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BetAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.BettorName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MinimumBet);
            this.groupBox1.Controls.Add(this.arekButton);
            this.groupBox1.Controls.Add(this.bartekButton);
            this.groupBox1.Controls.Add(this.janekButton);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dom bukmacherski";
            // 
            // DogNumber
            // 
            this.DogNumber.Location = new System.Drawing.Point(386, 169);
            this.DogNumber.Name = "DogNumber";
            this.DogNumber.Size = new System.Drawing.Size(53, 22);
            this.DogNumber.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(235, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "zł na charta numer";
            // 
            // BetAmount
            // 
            this.BetAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetAmount.Location = new System.Drawing.Point(176, 170);
            this.BetAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(53, 22);
            this.BetAmount.TabIndex = 13;
            this.BetAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Bets
            // 
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bets.Location = new System.Drawing.Point(85, 169);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(84, 23);
            this.Bets.TabIndex = 12;
            this.Bets.Text = "Stawia";
            this.Bets.UseVisualStyleBackColor = true;
            // 
            // BettorName
            // 
            this.BettorName.AutoSize = true;
            this.BettorName.Location = new System.Drawing.Point(15, 175);
            this.BettorName.Name = "BettorName";
            this.BettorName.Size = new System.Drawing.Size(46, 17);
            this.BettorName.TabIndex = 11;
            this.BettorName.Text = "Janek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(270, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zakłady";
            // 
            // MinimumBet
            // 
            this.MinimumBet.AutoSize = true;
            this.MinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumBet.Location = new System.Drawing.Point(7, 40);
            this.MinimumBet.Name = "MinimumBet";
            this.MinimumBet.Size = new System.Drawing.Size(131, 17);
            this.MinimumBet.TabIndex = 6;
            this.MinimumBet.Text = "Minimalny zakład";
            // 
            // arekButton
            // 
            this.arekButton.AutoSize = true;
            this.arekButton.Location = new System.Drawing.Point(7, 119);
            this.arekButton.Name = "arekButton";
            this.arekButton.Size = new System.Drawing.Size(58, 21);
            this.arekButton.TabIndex = 1;
            this.arekButton.TabStop = true;
            this.arekButton.Text = "Arek";
            this.arekButton.UseVisualStyleBackColor = true;
            // 
            // bartekButton
            // 
            this.bartekButton.AutoSize = true;
            this.bartekButton.Location = new System.Drawing.Point(7, 91);
            this.bartekButton.Name = "bartekButton";
            this.bartekButton.Size = new System.Drawing.Size(70, 21);
            this.bartekButton.TabIndex = 2;
            this.bartekButton.TabStop = true;
            this.bartekButton.Text = "Bartek";
            this.bartekButton.UseVisualStyleBackColor = true;
            // 
            // janekButton
            // 
            this.janekButton.AutoSize = true;
            this.janekButton.Location = new System.Drawing.Point(7, 63);
            this.janekButton.Name = "janekButton";
            this.janekButton.Size = new System.Drawing.Size(67, 21);
            this.janekButton.TabIndex = 3;
            this.janekButton.TabStop = true;
            this.janekButton.Text = "Janek";
            this.janekButton.UseVisualStyleBackColor = true;
            this.janekButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(487, 169);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start !";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // dog1
            // 
            this.dog1.Image = global::BettingHouse_TheGame.Properties.Resources.dog;
            this.dog1.Location = new System.Drawing.Point(23, 22);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(75, 20);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog1.TabIndex = 2;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = global::BettingHouse_TheGame.Properties.Resources.dog;
            this.dog2.Location = new System.Drawing.Point(23, 70);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(75, 20);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog2.TabIndex = 3;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = global::BettingHouse_TheGame.Properties.Resources.dog;
            this.dog3.Location = new System.Drawing.Point(23, 124);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(75, 20);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog3.TabIndex = 4;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = global::BettingHouse_TheGame.Properties.Resources.dog;
            this.dog4.Location = new System.Drawing.Point(23, 176);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(75, 20);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog4.TabIndex = 5;
            this.dog4.TabStop = false;
            // 
            // janekBet
            // 
            this.janekBet.Location = new System.Drawing.Point(270, 65);
            this.janekBet.Name = "janekBet";
            this.janekBet.Size = new System.Drawing.Size(292, 23);
            this.janekBet.TabIndex = 16;
            this.janekBet.Text = "Zakład Janka.";
            // 
            // bartekBet
            // 
            this.bartekBet.Location = new System.Drawing.Point(270, 93);
            this.bartekBet.Name = "bartekBet";
            this.bartekBet.Size = new System.Drawing.Size(292, 23);
            this.bartekBet.TabIndex = 17;
            this.bartekBet.Text = "Zakład Bartka.";
            // 
            // arekBet
            // 
            this.arekBet.Location = new System.Drawing.Point(270, 121);
            this.arekBet.Name = "arekBet";
            this.arekBet.Size = new System.Drawing.Size(292, 23);
            this.arekBet.TabIndex = 18;
            this.arekBet.Text = "Zakład Arka.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 456);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.racetrack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dzień na wyścigach";
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RadioButton janekButton;
        private System.Windows.Forms.NumericUpDown DogNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown BetAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.Label BettorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MinimumBet;
        private System.Windows.Forms.RadioButton arekButton;
        private System.Windows.Forms.RadioButton bartekButton;
        private System.Windows.Forms.Label arekBet;
        private System.Windows.Forms.Label bartekBet;
        private System.Windows.Forms.Label janekBet;
    }
}

