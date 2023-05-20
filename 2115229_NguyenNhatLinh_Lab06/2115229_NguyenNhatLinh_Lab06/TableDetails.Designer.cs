namespace _2115229_NguyenNhatLinh_Lab06
{
    partial class TableDetails
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
            this.dgvTableDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTableDetails
            // 
            this.dgvTableDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableDetails.Location = new System.Drawing.Point(95, 43);
            this.dgvTableDetails.Name = "dgvTableDetails";
            this.dgvTableDetails.Size = new System.Drawing.Size(548, 297);
            this.dgvTableDetails.TabIndex = 0;
            // 
            // TableDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTableDetails);
            this.Name = "TableDetails";
            this.Text = "TableDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTableDetails;
    }
}