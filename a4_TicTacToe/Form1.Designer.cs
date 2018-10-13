namespace a4_TicTacToe
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
            this.start = new System.Windows.Forms.Button();
            this.lblTopLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTopMid = new System.Windows.Forms.Label();
            this.lblTopRight = new System.Windows.Forms.Label();
            this.lblMidLeft = new System.Windows.Forms.Label();
            this.lblBotLeft = new System.Windows.Forms.Label();
            this.lblMidMid = new System.Windows.Forms.Label();
            this.lblMidRight = new System.Windows.Forms.Label();
            this.lblBotMid = new System.Windows.Forms.Label();
            this.lblBotRight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(1263, 556);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(163, 85);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // lblTopLeft
            // 
            this.lblTopLeft.AutoSize = true;
            this.lblTopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopLeft.Location = new System.Drawing.Point(37, 9);
            this.lblTopLeft.Name = "lblTopLeft";
            this.lblTopLeft.Size = new System.Drawing.Size(275, 272);
            this.lblTopLeft.TabIndex = 1;
            this.lblTopLeft.Tag = "00";
            this.lblTopLeft.Text = "X";
            this.lblTopLeft.Click += new System.EventHandler(this.Space_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(901, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(318, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 832);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // lblTopMid
            // 
            this.lblTopMid.AutoSize = true;
            this.lblTopMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopMid.Location = new System.Drawing.Point(347, 9);
            this.lblTopMid.Name = "lblTopMid";
            this.lblTopMid.Size = new System.Drawing.Size(275, 272);
            this.lblTopMid.TabIndex = 4;
            this.lblTopMid.Tag = "01";
            this.lblTopMid.Text = "X";
            this.lblTopMid.Click += new System.EventHandler(this.Space_Click);
            // 
            // lblTopRight
            // 
            this.lblTopRight.AutoSize = true;
            this.lblTopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopRight.Location = new System.Drawing.Point(657, 9);
            this.lblTopRight.Name = "lblTopRight";
            this.lblTopRight.Size = new System.Drawing.Size(275, 272);
            this.lblTopRight.TabIndex = 5;
            this.lblTopRight.Tag = "02";
            this.lblTopRight.Text = "X";
            this.lblTopRight.Click += new System.EventHandler(this.Space_Click);
            // 
            // lblMidLeft
            // 
            this.lblMidLeft.AutoSize = true;
            this.lblMidLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidLeft.Location = new System.Drawing.Point(37, 261);
            this.lblMidLeft.Name = "lblMidLeft";
            this.lblMidLeft.Size = new System.Drawing.Size(275, 272);
            this.lblMidLeft.TabIndex = 6;
            this.lblMidLeft.Tag = "10";
            this.lblMidLeft.Text = "X";
            this.lblMidLeft.Click += new System.EventHandler(this.Space_Click);
            // 
            // lblBotLeft
            // 
            this.lblBotLeft.AutoSize = true;
            this.lblBotLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotLeft.Location = new System.Drawing.Point(37, 497);
            this.lblBotLeft.Name = "lblBotLeft";
            this.lblBotLeft.Size = new System.Drawing.Size(275, 272);
            this.lblBotLeft.TabIndex = 7;
            this.lblBotLeft.Tag = "20";
            this.lblBotLeft.Text = "X";
            this.lblBotLeft.Click += new System.EventHandler(this.Space_Click);
            // 
            // lblMidMid
            // 
            this.lblMidMid.AutoSize = true;
            this.lblMidMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidMid.Location = new System.Drawing.Point(347, 261);
            this.lblMidMid.Name = "lblMidMid";
            this.lblMidMid.Size = new System.Drawing.Size(275, 272);
            this.lblMidMid.TabIndex = 8;
            this.lblMidMid.Tag = "11";
            this.lblMidMid.Text = "X";
            this.lblMidMid.Click += new System.EventHandler(this.Space_Click);
            // 
            // lblMidRight
            // 
            this.lblMidRight.AutoSize = true;
            this.lblMidRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidRight.Location = new System.Drawing.Point(657, 261);
            this.lblMidRight.Name = "lblMidRight";
            this.lblMidRight.Size = new System.Drawing.Size(275, 272);
            this.lblMidRight.TabIndex = 9;
            this.lblMidRight.Tag = "12";
            this.lblMidRight.Text = "X";
            this.lblMidRight.Click += new System.EventHandler(this.Space_Click);
            // 
            // lblBotMid
            // 
            this.lblBotMid.AutoSize = true;
            this.lblBotMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotMid.Location = new System.Drawing.Point(347, 497);
            this.lblBotMid.Name = "lblBotMid";
            this.lblBotMid.Size = new System.Drawing.Size(275, 272);
            this.lblBotMid.TabIndex = 10;
            this.lblBotMid.Tag = "21";
            this.lblBotMid.Text = "X";
            this.lblBotMid.Click += new System.EventHandler(this.Space_Click);
            // 
            // lblBotRight
            // 
            this.lblBotRight.AutoSize = true;
            this.lblBotRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotRight.Location = new System.Drawing.Point(657, 497);
            this.lblBotRight.Name = "lblBotRight";
            this.lblBotRight.Size = new System.Drawing.Size(275, 272);
            this.lblBotRight.TabIndex = 11;
            this.lblBotRight.Tag = "22";
            this.lblBotRight.Text = "X";
            this.lblBotRight.Click += new System.EventHandler(this.Space_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(628, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 832);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(21, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(962, 10);
            this.label13.TabIndex = 13;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(21, 497);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(962, 10);
            this.label14.TabIndex = 14;
            this.label14.Text = "label14";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(1105, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 412);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "label15";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(149, 1046);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 268);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 1372);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBotRight);
            this.Controls.Add(this.lblBotMid);
            this.Controls.Add(this.lblMidRight);
            this.Controls.Add(this.lblMidMid);
            this.Controls.Add(this.lblBotLeft);
            this.Controls.Add(this.lblMidLeft);
            this.Controls.Add(this.lblTopRight);
            this.Controls.Add(this.lblTopMid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTopLeft);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label lblTopLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTopMid;
        private System.Windows.Forms.Label lblTopRight;
        private System.Windows.Forms.Label lblMidLeft;
        private System.Windows.Forms.Label lblBotLeft;
        private System.Windows.Forms.Label lblMidMid;
        private System.Windows.Forms.Label lblMidRight;
        private System.Windows.Forms.Label lblBotMid;
        private System.Windows.Forms.Label lblBotRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

