namespace _2115229_NguyenNhatLinh_Lab06
{
    partial class MainForm
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
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoáBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhMụcHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemNhậtKýHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTables
            // 
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTables.Location = new System.Drawing.Point(50, 43);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTables.Size = new System.Drawing.Size(527, 296);
            this.dgvTables.TabIndex = 0;
            this.dgvTables.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTables_CellMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoáBànToolStripMenuItem,
            this.xemDanhMụcHoáĐơnToolStripMenuItem,
            this.xemNhậtKýHoáĐơnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 92);
            // 
            // xoáBànToolStripMenuItem
            // 
            this.xoáBànToolStripMenuItem.Name = "xoáBànToolStripMenuItem";
            this.xoáBànToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.xoáBànToolStripMenuItem.Text = "Xoá bàn ";
            this.xoáBànToolStripMenuItem.Click += new System.EventHandler(this.xoáBànToolStripMenuItem_Click);
            // 
            // xemDanhMụcHoáĐơnToolStripMenuItem
            // 
            this.xemDanhMụcHoáĐơnToolStripMenuItem.Name = "xemDanhMụcHoáĐơnToolStripMenuItem";
            this.xemDanhMụcHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.xemDanhMụcHoáĐơnToolStripMenuItem.Text = "Xem danh mục hoá đơn";
            // 
            // xemNhậtKýHoáĐơnToolStripMenuItem
            // 
            this.xemNhậtKýHoáĐơnToolStripMenuItem.Name = "xemNhậtKýHoáĐơnToolStripMenuItem";
            this.xemNhậtKýHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.xemNhậtKýHoáĐơnToolStripMenuItem.Text = "Xem nhật ký hoá đơn";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(628, 43);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(628, 93);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvTables);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xoáBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhMụcHoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemNhậtKýHoáĐơnToolStripMenuItem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
    }
}