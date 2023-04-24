namespace _2115229_NguyenNhatLinh_Lab05
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMSSV = new System.Windows.Forms.RadioButton();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.rdLop = new System.Windows.Forms.RadioButton();
            this.txtDuLieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDuLieu);
            this.groupBox1.Controls.Add(this.rdLop);
            this.groupBox1.Controls.Add(this.rdTen);
            this.groupBox1.Controls.Add(this.rdMSSV);
            this.groupBox1.Location = new System.Drawing.Point(41, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tuỳ chọn";
            // 
            // rdMSSV
            // 
            this.rdMSSV.AutoSize = true;
            this.rdMSSV.Checked = true;
            this.rdMSSV.Location = new System.Drawing.Point(19, 42);
            this.rdMSSV.Name = "rdMSSV";
            this.rdMSSV.Size = new System.Drawing.Size(57, 17);
            this.rdMSSV.TabIndex = 0;
            this.rdMSSV.TabStop = true;
            this.rdMSSV.Text = "Mã SV";
            this.rdMSSV.UseVisualStyleBackColor = true;
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Location = new System.Drawing.Point(122, 42);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(44, 17);
            this.rdTen.TabIndex = 1;
            this.rdTen.Text = "Tên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // rdLop
            // 
            this.rdLop.AutoSize = true;
            this.rdLop.Location = new System.Drawing.Point(222, 42);
            this.rdLop.Name = "rdLop";
            this.rdLop.Size = new System.Drawing.Size(43, 17);
            this.rdLop.TabIndex = 2;
            this.rdLop.Text = "Lớp";
            this.rdLop.UseVisualStyleBackColor = true;
            // 
            // txtDuLieu
            // 
            this.txtDuLieu.Location = new System.Drawing.Point(81, 107);
            this.txtDuLieu.Name = "txtDuLieu";
            this.txtDuLieu.Size = new System.Drawing.Size(130, 20);
            this.txtDuLieu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dữ liệu:";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(222, 107);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 20);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 254);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Tìm thông tin sinh viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnTim;
        public System.Windows.Forms.RadioButton rdLop;
        public System.Windows.Forms.RadioButton rdTen;
        public System.Windows.Forms.RadioButton rdMSSV;
        public System.Windows.Forms.TextBox txtDuLieu;
    }
}