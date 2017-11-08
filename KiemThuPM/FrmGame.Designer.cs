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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.picHinh);
            this.panel1.Location = new System.Drawing.Point(25, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 328);
            this.panel1.TabIndex = 0;
            // 
            // picHinh
            // 
            this.picHinh.BackColor = System.Drawing.Color.White;
            this.picHinh.Location = new System.Drawing.Point(14, 14);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(815, 301);
            this.picHinh.TabIndex = 0;
            this.picHinh.TabStop = false;
            // 
            // lbLevel
            // 
            this.lbLevel.BackColor = System.Drawing.Color.Orchid;
            this.lbLevel.Font = new System.Drawing.Font("Arial Unicode MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lbLevel.ForeColor = System.Drawing.Color.Teal;
            this.lbLevel.Location = new System.Drawing.Point(366, 9);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(121, 51);
            this.lbLevel.TabIndex = 2;
            this.lbLevel.Text = "Level";
            this.lbLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbButton
            // 
            this.gbButton.Location = new System.Drawing.Point(53, 471);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(597, 135);
            this.gbButton.TabIndex = 6;
            this.gbButton.TabStop = false;
            // 
            // gbLable
            // 
            this.gbLable.Location = new System.Drawing.Point(50, 371);
            this.gbLable.Name = "gbLable";
            this.gbLable.Size = new System.Drawing.Size(600, 80);
            this.gbLable.TabIndex = 6;
            this.gbLable.TabStop = false;
            // 
            // btGoiY
            // 
            this.btGoiY.BackColor = System.Drawing.Color.Cyan;
            this.btGoiY.Location = new System.Drawing.Point(50, 157);
            this.btGoiY.Name = "btGoiY";
            this.btGoiY.Size = new System.Drawing.Size(133, 36);
            this.btGoiY.TabIndex = 3;
            this.btGoiY.Text = "Suggest";
            this.btGoiY.UseVisualStyleBackColor = false;
            this.btGoiY.Click += new System.EventHandler(this.btGoiY_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Red;
            this.btThoat.Location = new System.Drawing.Point(50, 199);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(133, 36);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Exit";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // lbDiem
            // 
            this.lbDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(44, 11);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(143, 80);
            this.lbDiem.TabIndex = 4;
            this.lbDiem.Text = "Điểm";
            this.lbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btEnter
            // 
            this.btEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btEnter.Location = new System.Drawing.Point(73, 94);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(85, 57);
            this.btEnter.TabIndex = 5;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = false;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btEnter);
            this.panel3.Controls.Add(this.lbDiem);
            this.panel3.Controls.Add(this.btThoat);
            this.panel3.Controls.Add(this.btGoiY);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(698, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 247);
            this.panel3.TabIndex = 4;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KiemThuPM.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 640);
            this.Controls.Add(this.gbLable);
            this.Controls.Add(this.gbButton);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.FrmXuLy_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.panel3.ResumeLayout(false);
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
    }
}