namespace KiemThuPM
{
    partial class FrmSavePoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSavePoint));
            this.lbNickName = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNickName
            // 
            this.lbNickName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNickName.Location = new System.Drawing.Point(217, 35);
            this.lbNickName.Name = "lbNickName";
            this.lbNickName.Size = new System.Drawing.Size(163, 36);
            this.lbNickName.TabIndex = 0;
            this.lbNickName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDiem
            // 
            this.lbDiem.BackColor = System.Drawing.Color.Salmon;
            this.lbDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDiem.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.Color.Green;
            this.lbDiem.Location = new System.Drawing.Point(218, 95);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(159, 66);
            this.lbDiem.TabIndex = 1;
            this.lbDiem.Text = "Save point";
            this.lbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSave.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.Green;
            this.btSave.Location = new System.Drawing.Point(104, 419);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(124, 45);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Salmon;
            this.btExit.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.GreenYellow;
            this.btExit.Location = new System.Drawing.Point(340, 416);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(126, 45);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FrmLuuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KiemThuPM.Properties.Resources.doremon3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 488);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbNickName);
            this.Controls.Add(this.lbDiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLuuDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save point";
            this.Load += new System.EventHandler(this.FrmLuuDiem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNickName;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExit;
    }
}