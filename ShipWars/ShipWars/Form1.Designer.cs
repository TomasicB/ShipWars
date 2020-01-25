namespace ShipWars
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHits = new System.Windows.Forms.Label();
            this.lblShots = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbP2ships = new System.Windows.Forms.PictureBox();
            this.pb_down_p1 = new System.Windows.Forms.PictureBox();
            this.pb_up_p1 = new System.Windows.Forms.PictureBox();
            this.bContinue = new System.Windows.Forms.Button();
            this.pbP1ships = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHitsP1 = new System.Windows.Forms.Label();
            this.lblShotsP1 = new System.Windows.Forms.Label();
            this.lblp1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timRound = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltimeM = new System.Windows.Forms.Label();
            this.lbltimeS = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbP2ships)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down_p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up_p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbP1ships)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHits);
            this.groupBox1.Controls.Add(this.lblShots);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pbP2ships);
            this.groupBox1.Location = new System.Drawing.Point(555, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 185);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PC";
            // 
            // lblHits
            // 
            this.lblHits.AutoSize = true;
            this.lblHits.Location = new System.Drawing.Point(51, 51);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(0, 13);
            this.lblHits.TabIndex = 11;
            // 
            // lblShots
            // 
            this.lblShots.AutoSize = true;
            this.lblShots.Location = new System.Drawing.Point(51, 19);
            this.lblShots.Name = "lblShots";
            this.lblShots.Size = new System.Drawing.Size(0, 13);
            this.lblShots.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Shots:";
            // 
            // pbP2ships
            // 
            this.pbP2ships.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbP2ships.Location = new System.Drawing.Point(100, 19);
            this.pbP2ships.Name = "pbP2ships";
            this.pbP2ships.Size = new System.Drawing.Size(133, 166);
            this.pbP2ships.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbP2ships.TabIndex = 6;
            this.pbP2ships.TabStop = false;
            // 
            // pb_down_p1
            // 
            this.pb_down_p1.Location = new System.Drawing.Point(60, 218);
            this.pb_down_p1.Name = "pb_down_p1";
            this.pb_down_p1.Size = new System.Drawing.Size(457, 229);
            this.pb_down_p1.TabIndex = 3;
            this.pb_down_p1.TabStop = false;
            this.pb_down_p1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_down_p1_MouseUp);
            // 
            // pb_up_p1
            // 
            this.pb_up_p1.Location = new System.Drawing.Point(90, 12);
            this.pb_up_p1.Name = "pb_up_p1";
            this.pb_up_p1.Size = new System.Drawing.Size(397, 199);
            this.pb_up_p1.TabIndex = 0;
            this.pb_up_p1.TabStop = false;
            this.pb_up_p1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_up_p1_MouseDown);
            // 
            // bContinue
            // 
            this.bContinue.Location = new System.Drawing.Point(636, 208);
            this.bContinue.Name = "bContinue";
            this.bContinue.Size = new System.Drawing.Size(75, 23);
            this.bContinue.TabIndex = 6;
            this.bContinue.Text = "Continue";
            this.bContinue.UseVisualStyleBackColor = true;
            this.bContinue.Click += new System.EventHandler(this.bContinue_Click);
            // 
            // pbP1ships
            // 
            this.pbP1ships.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbP1ships.Location = new System.Drawing.Point(81, 19);
            this.pbP1ships.Name = "pbP1ships";
            this.pbP1ships.Size = new System.Drawing.Size(153, 191);
            this.pbP1ships.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbP1ships.TabIndex = 5;
            this.pbP1ships.TabStop = false;
            this.pbP1ships.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbP1ships_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHitsP1);
            this.groupBox2.Controls.Add(this.pbP1ships);
            this.groupBox2.Controls.Add(this.lblShotsP1);
            this.groupBox2.Controls.Add(this.lblp1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(555, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 210);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 1";
            // 
            // lblHitsP1
            // 
            this.lblHitsP1.AutoSize = true;
            this.lblHitsP1.Location = new System.Drawing.Point(51, 83);
            this.lblHitsP1.Name = "lblHitsP1";
            this.lblHitsP1.Size = new System.Drawing.Size(0, 13);
            this.lblHitsP1.TabIndex = 15;
            // 
            // lblShotsP1
            // 
            this.lblShotsP1.AutoSize = true;
            this.lblShotsP1.Location = new System.Drawing.Point(51, 51);
            this.lblShotsP1.Name = "lblShotsP1";
            this.lblShotsP1.Size = new System.Drawing.Size(0, 13);
            this.lblShotsP1.TabIndex = 14;
            // 
            // lblp1
            // 
            this.lblp1.AutoSize = true;
            this.lblp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp1.Location = new System.Drawing.Point(8, 19);
            this.lblp1.Name = "lblp1";
            this.lblp1.Size = new System.Drawing.Size(65, 20);
            this.lblp1.TabIndex = 6;
            this.lblp1.Text = "Player 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hits:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Shots:";
            // 
            // timRound
            // 
            this.timRound.Tick += new System.EventHandler(this.timRound_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Player 2 field:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Player 1 field:";
            // 
            // lbltimeM
            // 
            this.lbltimeM.AutoSize = true;
            this.lbltimeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimeM.Location = new System.Drawing.Point(493, 13);
            this.lbltimeM.Name = "lbltimeM";
            this.lbltimeM.Size = new System.Drawing.Size(0, 24);
            this.lbltimeM.TabIndex = 13;
            // 
            // lbltimeS
            // 
            this.lbltimeS.AutoSize = true;
            this.lbltimeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimeS.Location = new System.Drawing.Point(518, 13);
            this.lbltimeS.Name = "lbltimeS";
            this.lbltimeS.Size = new System.Drawing.Size(0, 24);
            this.lbltimeS.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.lbltimeS);
            this.Controls.Add(this.lbltimeM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bContinue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pb_down_p1);
            this.Controls.Add(this.pb_up_p1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbP2ships)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down_p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up_p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbP1ships)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_up_p1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pb_down_p1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bContinue;
        private System.Windows.Forms.PictureBox pbP1ships;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbP2ships;
        public System.Windows.Forms.Label lblp1;
        public System.Windows.Forms.Timer timRound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHits;
        private System.Windows.Forms.Label lblShots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHitsP1;
        private System.Windows.Forms.Label lblShotsP1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbltimeM;
        private System.Windows.Forms.Label lbltimeS;
    }
}

