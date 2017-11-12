namespace KiemThuPM
{
    partial class FrmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.lbLevel = new System.Windows.Forms.Label();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.gbLable = new System.Windows.Forms.GroupBox();
            this.btGoiY = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.lbDiem = new System.Windows.Forms.Label();
            this.btEnter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.picHinh);
            this.panel1.Location = new System.Drawing.Point(19, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 272);
            this.panel1.TabIndex = 0;
            // 
            // picHinh
            // 
            this.picHinh.BackColor = System.Drawing.Color.White;
            this.picHinh.Location = new System.Drawing.Point(12, 13);
            this.picHinh.Margin = new System.Windows.Forms.Padding(2);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(651, 245);
            this.picHinh.TabIndex = 0;
            this.picHinh.TabStop = false;
            // 
            // lbLevel
            // 
            this.lbLevel.BackColor = System.Drawing.Color.DarkViolet;
            this.lbLevel.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lbLevel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbLevel.Location = new System.Drawing.Point(308, 22);
            this.lbLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(91, 41);
            this.lbLevel.TabIndex = 2;
            this.lbLevel.Text = "1";
            this.lbLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            // 
            // gbButton
            // 
            this.gbButton.Location = new System.Drawing.Point(38, 399);
            this.gbButton.Margin = new System.Windows.Forms.Padding(2);
            this.gbButton.Name = "gbButton";
            this.gbButton.Padding = new System.Windows.Forms.Padding(2);
            this.gbButton.Size = new System.Drawing.Size(656, 110);
            this.gbButton.TabIndex = 6;
            this.gbButton.TabStop = false;
            // 
            // gbLable
            // 
            this.gbLable.Location = new System.Drawing.Point(38, 330);
            this.gbLable.Margin = new System.Windows.Forms.Padding(2);
            this.gbLable.Name = "gbLable";
            this.gbLable.Padding = new System.Windows.Forms.Padding(2);
            this.gbLable.Size = new System.Drawing.Size(658, 65);
            this.gbLable.TabIndex = 6;
            this.gbLable.TabStop = false;
            // 
            // btGoiY
            // 
            this.btGoiY.BackColor = System.Drawing.Color.Cyan;
            this.btGoiY.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoiY.ForeColor = System.Drawing.Color.Navy;
            this.btGoiY.Location = new System.Drawing.Point(10, 155);
            this.btGoiY.Margin = new System.Windows.Forms.Padding(2);
            this.btGoiY.Name = "btGoiY";
            this.btGoiY.Size = new System.Drawing.Size(80, 41);
            this.btGoiY.TabIndex = 3;
            this.btGoiY.Text = "Suggest";
            this.btGoiY.UseVisualStyleBackColor = false;
            this.btGoiY.Click += new System.EventHandler(this.btGoiY_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Red;
            this.btThoat.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThoat.Location = new System.Drawing.Point(100, 155);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(80, 41);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Exit";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // lbDiem
            // 
            this.lbDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbDiem.Font = new System.Drawing.Font("Ravie", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbDiem.Location = new System.Drawing.Point(37, 9);
            this.lbDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(107, 65);
            this.lbDiem.TabIndex = 4;
            this.lbDiem.Text = "5";
            this.lbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btEnter
            // 
            this.btEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btEnter.Font = new System.Drawing.Font("Ravie", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnter.ForeColor = System.Drawing.Color.Green;
            this.btEnter.Location = new System.Drawing.Point(39, 76);
            this.btEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(103, 75);
            this.btEnter.TabIndex = 5;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = false;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.btEnter);
            this.panel3.Controls.Add(this.lbDiem);
            this.panel3.Controls.Add(this.btThoat);
            this.panel3.Controls.Add(this.btGoiY);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(714, 308);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 201);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KiemThuPM.Properties.Resources.doremon_noback;
            this.pictureBox1.Location = new System.Drawing.Point(717, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbLable);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.gbButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.FrmXuLy_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picHinh;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.GroupBox gbButton;
        private System.Windows.Forms.GroupBox gbLable;
        private System.Windows.Forms.Button btGoiY;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}