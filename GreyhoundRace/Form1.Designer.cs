﻿namespace GreyhoundRace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.rbMcGee = new System.Windows.Forms.RadioButton();
            this.rbGeorge = new System.Windows.Forms.RadioButton();
            this.btnBet = new System.Windows.Forms.Button();
            this.udBoxBet = new System.Windows.Forms.NumericUpDown();
            this.udBoxDog = new System.Windows.Forms.NumericUpDown();
            this.btnRace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblJoe = new System.Windows.Forms.Label();
            this.lblMcGee = new System.Windows.Forms.Label();
            this.lblGeorge = new System.Windows.Forms.Label();
            this.lblBettor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbDog1 = new System.Windows.Forms.PictureBox();
            this.pbDog4 = new System.Windows.Forms.PictureBox();
            this.pbDog3 = new System.Windows.Forms.PictureBox();
            this.pbDog2 = new System.Windows.Forms.PictureBox();
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            this.btnLockIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Location = new System.Drawing.Point(44, 333);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(52, 21);
            this.rbJoe.TabIndex = 3;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.CheckedChanged += new System.EventHandler(this.rbJoe_CheckedChanged);
            // 
            // rbMcGee
            // 
            this.rbMcGee.AutoSize = true;
            this.rbMcGee.Location = new System.Drawing.Point(44, 361);
            this.rbMcGee.Name = "rbMcGee";
            this.rbMcGee.Size = new System.Drawing.Size(74, 21);
            this.rbMcGee.TabIndex = 4;
            this.rbMcGee.TabStop = true;
            this.rbMcGee.Text = "McGee";
            this.rbMcGee.UseVisualStyleBackColor = true;
            this.rbMcGee.CheckedChanged += new System.EventHandler(this.rbMcGee_CheckedChanged);
            // 
            // rbGeorge
            // 
            this.rbGeorge.AutoSize = true;
            this.rbGeorge.Location = new System.Drawing.Point(44, 389);
            this.rbGeorge.Name = "rbGeorge";
            this.rbGeorge.Size = new System.Drawing.Size(77, 21);
            this.rbGeorge.TabIndex = 5;
            this.rbGeorge.TabStop = true;
            this.rbGeorge.Text = "George";
            this.rbGeorge.UseVisualStyleBackColor = true;
            this.rbGeorge.CheckedChanged += new System.EventHandler(this.rbGeorge_CheckedChanged);
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(426, 448);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(98, 80);
            this.btnBet.TabIndex = 7;
            this.btnBet.Text = "Place Bet!";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // udBoxBet
            // 
            this.udBoxBet.Location = new System.Drawing.Point(116, 448);
            this.udBoxBet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udBoxBet.Name = "udBoxBet";
            this.udBoxBet.Size = new System.Drawing.Size(75, 22);
            this.udBoxBet.TabIndex = 8;
            // 
            // udBoxDog
            // 
            this.udBoxDog.Location = new System.Drawing.Point(116, 506);
            this.udBoxDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udBoxDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udBoxDog.Name = "udBoxDog";
            this.udBoxDog.Size = new System.Drawing.Size(75, 22);
            this.udBoxDog.TabIndex = 9;
            this.udBoxDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRace
            // 
            this.btnRace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRace.Enabled = false;
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.ForeColor = System.Drawing.Color.Green;
            this.btnRace.Location = new System.Drawing.Point(738, 448);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(98, 80);
            this.btnRace.TabIndex = 11;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bet  $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dog  #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bettor Name:     Cash Available:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblJoe
            // 
            this.lblJoe.Location = new System.Drawing.Point(429, 335);
            this.lblJoe.Name = "lblJoe";
            this.lblJoe.Size = new System.Drawing.Size(407, 23);
            this.lblJoe.TabIndex = 22;
            this.lblJoe.Text = "label4";
            // 
            // lblMcGee
            // 
            this.lblMcGee.Location = new System.Drawing.Point(429, 363);
            this.lblMcGee.Name = "lblMcGee";
            this.lblMcGee.Size = new System.Drawing.Size(407, 23);
            this.lblMcGee.TabIndex = 23;
            this.lblMcGee.Text = "label5";
            // 
            // lblGeorge
            // 
            this.lblGeorge.Location = new System.Drawing.Point(429, 391);
            this.lblGeorge.Name = "lblGeorge";
            this.lblGeorge.Size = new System.Drawing.Size(407, 23);
            this.lblGeorge.TabIndex = 24;
            this.lblGeorge.Text = "label6";
            // 
            // lblBettor
            // 
            this.lblBettor.AutoSize = true;
            this.lblBettor.Location = new System.Drawing.Point(230, 480);
            this.lblBettor.Name = "lblBettor";
            this.lblBettor.Size = new System.Drawing.Size(46, 17);
            this.lblBettor.TabIndex = 25;
            this.lblBettor.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Bettor:";
            // 
            // pbDog1
            // 
            this.pbDog1.Image = global::GreyhoundRace.Properties.Resources.Dog1;
            this.pbDog1.Location = new System.Drawing.Point(44, 24);
            this.pbDog1.Name = "pbDog1";
            this.pbDog1.Size = new System.Drawing.Size(81, 48);
            this.pbDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog1.TabIndex = 17;
            this.pbDog1.TabStop = false;
            // 
            // pbDog4
            // 
            this.pbDog4.Image = global::GreyhoundRace.Properties.Resources.Dog4;
            this.pbDog4.Location = new System.Drawing.Point(44, 244);
            this.pbDog4.Name = "pbDog4";
            this.pbDog4.Size = new System.Drawing.Size(81, 37);
            this.pbDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog4.TabIndex = 20;
            this.pbDog4.TabStop = false;
            // 
            // pbDog3
            // 
            this.pbDog3.Image = global::GreyhoundRace.Properties.Resources.Dog3;
            this.pbDog3.Location = new System.Drawing.Point(44, 169);
            this.pbDog3.Name = "pbDog3";
            this.pbDog3.Size = new System.Drawing.Size(81, 47);
            this.pbDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog3.TabIndex = 19;
            this.pbDog3.TabStop = false;
            // 
            // pbDog2
            // 
            this.pbDog2.Image = global::GreyhoundRace.Properties.Resources.Dog2;
            this.pbDog2.Location = new System.Drawing.Point(44, 104);
            this.pbDog2.Name = "pbDog2";
            this.pbDog2.Size = new System.Drawing.Size(81, 37);
            this.pbDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog2.TabIndex = 18;
            this.pbDog2.TabStop = false;
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.Image = ((System.Drawing.Image)(resources.GetObject("pbRaceTrack.Image")));
            this.pbRaceTrack.Location = new System.Drawing.Point(35, 12);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(801, 287);
            this.pbRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaceTrack.TabIndex = 21;
            this.pbRaceTrack.TabStop = false;
            // 
            // btnLockIn
            // 
            this.btnLockIn.Location = new System.Drawing.Point(530, 448);
            this.btnLockIn.Name = "btnLockIn";
            this.btnLockIn.Size = new System.Drawing.Size(98, 80);
            this.btnLockIn.TabIndex = 27;
            this.btnLockIn.Text = "Lock In Bets!";
            this.btnLockIn.UseVisualStyleBackColor = true;
            this.btnLockIn.Click += new System.EventHandler(this.btnLockIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(874, 552);
            this.Controls.Add(this.btnLockIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBettor);
            this.Controls.Add(this.lblGeorge);
            this.Controls.Add(this.lblMcGee);
            this.Controls.Add(this.lblJoe);
            this.Controls.Add(this.pbDog1);
            this.Controls.Add(this.pbDog4);
            this.Controls.Add(this.pbDog3);
            this.Controls.Add(this.pbDog2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.udBoxDog);
            this.Controls.Add(this.udBoxBet);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.rbGeorge);
            this.Controls.Add(this.rbMcGee);
            this.Controls.Add(this.rbJoe);
            this.Controls.Add(this.pbRaceTrack);
            this.Name = "Form1";
            this.Text = "Dog Race!";
            ((System.ComponentModel.ISupportInitialize)(this.udBoxBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.RadioButton rbMcGee;
        private System.Windows.Forms.RadioButton rbGeorge;
        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.NumericUpDown udBoxBet;
        private System.Windows.Forms.NumericUpDown udBoxDog;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbDog1;
        private System.Windows.Forms.PictureBox pbDog2;
        private System.Windows.Forms.PictureBox pbDog3;
        private System.Windows.Forms.PictureBox pbDog4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblJoe;
        private System.Windows.Forms.Label lblMcGee;
        private System.Windows.Forms.Label lblGeorge;
        private System.Windows.Forms.Label lblBettor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLockIn;
    }
}
