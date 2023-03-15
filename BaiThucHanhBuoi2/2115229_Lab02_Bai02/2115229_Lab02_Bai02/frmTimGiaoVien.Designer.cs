namespace _2115229_Lab02_Bai02
{
    partial class frmTimGiaoVien
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
            this.grbTimGiaoVien = new System.Windows.Forms.GroupBox();
            this.rdMaGV = new System.Windows.Forms.RadioButton();
            this.rdSDT = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grbTimGiaoVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTimGiaoVien
            // 
            this.grbTimGiaoVien.Controls.Add(this.button1);
            this.grbTimGiaoVien.Controls.Add(this.txtThongTin);
            this.grbTimGiaoVien.Controls.Add(this.label1);
            this.grbTimGiaoVien.Controls.Add(this.rdHoTen);
            this.grbTimGiaoVien.Controls.Add(this.rdSDT);
            this.grbTimGiaoVien.Controls.Add(this.rdMaGV);
            this.grbTimGiaoVien.Location = new System.Drawing.Point(257, 86);
            this.grbTimGiaoVien.Name = "grbTimGiaoVien";
            this.grbTimGiaoVien.Size = new System.Drawing.Size(356, 120);
            this.grbTimGiaoVien.TabIndex = 0;
            this.grbTimGiaoVien.TabStop = false;
            this.grbTimGiaoVien.Text = "Tìm theo";
            // 
            // rdMaGV
            // 
            this.rdMaGV.AutoSize = true;
            this.rdMaGV.Location = new System.Drawing.Point(6, 37);
            this.rdMaGV.Name = "rdMaGV";
            this.rdMaGV.Size = new System.Drawing.Size(58, 17);
            this.rdMaGV.TabIndex = 0;
            this.rdMaGV.TabStop = true;
            this.rdMaGV.Text = "Mã GV";
            this.rdMaGV.UseVisualStyleBackColor = true;
            // 
            // rdSDT
            // 
            this.rdSDT.AutoSize = true;
            this.rdSDT.Location = new System.Drawing.Point(182, 37);
            this.rdSDT.Name = "rdSDT";
            this.rdSDT.Size = new System.Drawing.Size(88, 17);
            this.rdSDT.TabIndex = 0;
            this.rdSDT.TabStop = true;
            this.rdSDT.Text = "Số điện thoại";
            this.rdSDT.UseVisualStyleBackColor = true;
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Location = new System.Drawing.Point(98, 37);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(61, 17);
            this.rdHoTen.TabIndex = 0;
            this.rdHoTen.TabStop = true;
            this.rdHoTen.Text = "Họ Tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã GV";
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(69, 82);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(167, 20);
            this.txtThongTin.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTimGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbTimGiaoVien);
            this.Name = "frmTimGiaoVien";
            this.Text = "Tìm thông tin giáo viên";
            this.grbTimGiaoVien.ResumeLayout(false);
            this.grbTimGiaoVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTimGiaoVien;
        private System.Windows.Forms.RadioButton rdMaGV;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdSDT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Label label1;
    }
}