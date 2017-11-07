namespace DogRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblSmith = new System.Windows.Forms.Label();
            this.lblTrinity = new System.Windows.Forms.Label();
            this.lblNeo = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.NudBet = new System.Windows.Forms.NumericUpDown();
            this.rbSmith = new System.Windows.Forms.RadioButton();
            this.rbTrinity = new System.Windows.Forms.RadioButton();
            this.rbNeo = new System.Windows.Forms.RadioButton();
            this.txtSmith = new System.Windows.Forms.TextBox();
            this.txtTrinity = new System.Windows.Forms.TextBox();
            this.txtNeo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NudDog = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gamblers\' Money";
            // 
            // lblSmith
            // 
            this.lblSmith.AutoSize = true;
            this.lblSmith.Location = new System.Drawing.Point(132, 128);
            this.lblSmith.Name = "lblSmith";
            this.lblSmith.Size = new System.Drawing.Size(13, 13);
            this.lblSmith.TabIndex = 1;
            this.lblSmith.Text = "0";
            // 
            // lblTrinity
            // 
            this.lblTrinity.AutoSize = true;
            this.lblTrinity.Location = new System.Drawing.Point(132, 154);
            this.lblTrinity.Name = "lblTrinity";
            this.lblTrinity.Size = new System.Drawing.Size(13, 13);
            this.lblTrinity.TabIndex = 2;
            this.lblTrinity.Text = "0";
            // 
            // lblNeo
            // 
            this.lblNeo.AutoSize = true;
            this.lblNeo.Location = new System.Drawing.Point(132, 178);
            this.lblNeo.Name = "lblNeo";
            this.lblNeo.Size = new System.Drawing.Size(13, 13);
            this.lblNeo.TabIndex = 3;
            this.lblNeo.Text = "0";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(43, 231);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 5;
            this.btnBet.Text = "Place Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(145, 231);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(317, 231);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(75, 23);
            this.btnRace.TabIndex = 7;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // NudBet
            // 
            this.NudBet.Location = new System.Drawing.Point(272, 174);
            this.NudBet.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NudBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NudBet.Name = "NudBet";
            this.NudBet.ReadOnly = true;
            this.NudBet.Size = new System.Drawing.Size(120, 20);
            this.NudBet.TabIndex = 9;
            this.NudBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // rbSmith
            // 
            this.rbSmith.AutoSize = true;
            this.rbSmith.Location = new System.Drawing.Point(32, 128);
            this.rbSmith.Name = "rbSmith";
            this.rbSmith.Size = new System.Drawing.Size(51, 17);
            this.rbSmith.TabIndex = 10;
            this.rbSmith.TabStop = true;
            this.rbSmith.Text = "Smith";
            this.rbSmith.UseVisualStyleBackColor = true;
            this.rbSmith.CheckedChanged += new System.EventHandler(this.rbSmith_CheckedChanged);
            // 
            // rbTrinity
            // 
            this.rbTrinity.AutoSize = true;
            this.rbTrinity.Location = new System.Drawing.Point(31, 152);
            this.rbTrinity.Name = "rbTrinity";
            this.rbTrinity.Size = new System.Drawing.Size(53, 17);
            this.rbTrinity.TabIndex = 11;
            this.rbTrinity.TabStop = true;
            this.rbTrinity.Text = "Trinity";
            this.rbTrinity.UseVisualStyleBackColor = true;
            this.rbTrinity.CheckedChanged += new System.EventHandler(this.rbTrinity_CheckedChanged);
            // 
            // rbNeo
            // 
            this.rbNeo.AutoSize = true;
            this.rbNeo.Location = new System.Drawing.Point(30, 176);
            this.rbNeo.Name = "rbNeo";
            this.rbNeo.Size = new System.Drawing.Size(45, 17);
            this.rbNeo.TabIndex = 12;
            this.rbNeo.TabStop = true;
            this.rbNeo.Text = "Neo";
            this.rbNeo.UseVisualStyleBackColor = true;
            this.rbNeo.CheckedChanged += new System.EventHandler(this.rbNeo_CheckedChanged);
            // 
            // txtSmith
            // 
            this.txtSmith.Location = new System.Drawing.Point(428, 125);
            this.txtSmith.Name = "txtSmith";
            this.txtSmith.ReadOnly = true;
            this.txtSmith.Size = new System.Drawing.Size(240, 20);
            this.txtSmith.TabIndex = 13;
            // 
            // txtTrinity
            // 
            this.txtTrinity.Location = new System.Drawing.Point(428, 149);
            this.txtTrinity.Name = "txtTrinity";
            this.txtTrinity.ReadOnly = true;
            this.txtTrinity.Size = new System.Drawing.Size(240, 20);
            this.txtTrinity.TabIndex = 14;
            // 
            // txtNeo
            // 
            this.txtNeo.Location = new System.Drawing.Point(428, 173);
            this.txtNeo.Name = "txtNeo";
            this.txtNeo.ReadOnly = true;
            this.txtNeo.Size = new System.Drawing.Size(240, 20);
            this.txtNeo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Dog:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "#";
            // 
            // NudDog
            // 
            this.NudDog.Location = new System.Drawing.Point(272, 149);
            this.NudDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NudDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudDog.Name = "NudDog";
            this.NudDog.ReadOnly = true;
            this.NudDog.Size = new System.Drawing.Size(120, 20);
            this.NudDog.TabIndex = 23;
            this.NudDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Instructions:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Max bet is $15 Minimum bet is $5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "To place a bet you must select a Gambler.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "There are 4 Dogs available to bet on.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Each Gambler starts with $50";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 451);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "To Reset the Game press the reset button.";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(25, 473);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(208, 30);
            this.label15.TabIndex = 0;
            this.label15.Text = "When you reach less than $5 you are \'Busted\' and can no longer play.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(417, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 127);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(424, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Dog 1 - Rufus";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(541, 268);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 116);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(555, 242);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Dog 2 - Stanly";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(417, 423);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 122);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(426, 400);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Dog 3 - Rex";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(541, 430);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(93, 119);
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(547, 406);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Dog 4 - Brian";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(685, 561);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NudDog);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNeo);
            this.Controls.Add(this.txtTrinity);
            this.Controls.Add(this.txtSmith);
            this.Controls.Add(this.rbNeo);
            this.Controls.Add(this.rbTrinity);
            this.Controls.Add(this.rbSmith);
            this.Controls.Add(this.NudBet);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lblNeo);
            this.Controls.Add(this.lblTrinity);
            this.Controls.Add(this.lblSmith);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSmith;
        private System.Windows.Forms.Label lblTrinity;
        private System.Windows.Forms.Label lblNeo;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.NumericUpDown NudBet;
        private System.Windows.Forms.RadioButton rbSmith;
        private System.Windows.Forms.RadioButton rbTrinity;
        private System.Windows.Forms.RadioButton rbNeo;
        private System.Windows.Forms.TextBox txtSmith;
        private System.Windows.Forms.TextBox txtTrinity;
        private System.Windows.Forms.TextBox txtNeo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NudDog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label19;
    }
}

