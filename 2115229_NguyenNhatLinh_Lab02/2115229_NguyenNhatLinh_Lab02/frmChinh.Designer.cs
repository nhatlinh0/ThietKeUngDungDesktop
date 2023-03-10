namespace _2115229_NguyenNhatLinh_Lab02
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nguyễnNhậtLinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlBai4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyễnNhậtLinhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nguyễnNhậtLinhToolStripMenuItem
            // 
            this.nguyễnNhậtLinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmlBai1,
            this.tsmlBai2,
            this.tsmlBai3,
            this.tsmlBai4});
            this.nguyễnNhậtLinhToolStripMenuItem.Name = "nguyễnNhậtLinhToolStripMenuItem";
            this.nguyễnNhậtLinhToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.nguyễnNhậtLinhToolStripMenuItem.Text = "Nguyễn Nhật Linh";
            // 
            // tsmlBai1
            // 
            this.tsmlBai1.Image = ((System.Drawing.Image)(resources.GetObject("tsmlBai1.Image")));
            this.tsmlBai1.Name = "tsmlBai1";
            this.tsmlBai1.Size = new System.Drawing.Size(180, 22);
            this.tsmlBai1.Text = "Bài 1";
            this.tsmlBai1.Click += new System.EventHandler(this.tsmlBai1_Click);
            // 
            // tsmlBai2
            // 
            this.tsmlBai2.Image = ((System.Drawing.Image)(resources.GetObject("tsmlBai2.Image")));
            this.tsmlBai2.Name = "tsmlBai2";
            this.tsmlBai2.Size = new System.Drawing.Size(180, 22);
            this.tsmlBai2.Text = "Bài 2";
            this.tsmlBai2.Click += new System.EventHandler(this.tsmlBai2_Click);
            // 
            // tsmlBai3
            // 
            this.tsmlBai3.Image = ((System.Drawing.Image)(resources.GetObject("tsmlBai3.Image")));
            this.tsmlBai3.Name = "tsmlBai3";
            this.tsmlBai3.Size = new System.Drawing.Size(180, 22);
            this.tsmlBai3.Text = "Bài 3";
            this.tsmlBai3.Click += new System.EventHandler(this.tsmlBai3_Click);
            // 
            // tsmlBai4
            // 
            this.tsmlBai4.Name = "tsmlBai4";
            this.tsmlBai4.Size = new System.Drawing.Size(180, 22);
            this.tsmlBai4.Text = "Bài 4";
            this.tsmlBai4.Click += new System.EventHandler(this.tsmlBai4_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Chương Trình Chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nguyễnNhậtLinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmlBai1;
        private System.Windows.Forms.ToolStripMenuItem tsmlBai2;
        private System.Windows.Forms.ToolStripMenuItem tsmlBai3;
        private System.Windows.Forms.ToolStripMenuItem tsmlBai4;
    }
}

