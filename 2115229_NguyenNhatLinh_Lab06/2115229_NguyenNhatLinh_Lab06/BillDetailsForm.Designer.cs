namespace _2115229_NguyenNhatLinh_Lab06
{
    partial class BillDetailsForm
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
            this.dgvBillsDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillsDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBillsDetails
            // 
            this.dgvBillsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillsDetails.Location = new System.Drawing.Point(50, 39);
            this.dgvBillsDetails.Name = "dgvBillsDetails";
            this.dgvBillsDetails.Size = new System.Drawing.Size(621, 293);
            this.dgvBillsDetails.TabIndex = 0;
            // 
            // BillDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBillsDetails);
            this.Name = "BillDetailsForm";
            this.Text = "BillDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillsDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBillsDetails;
    }
}