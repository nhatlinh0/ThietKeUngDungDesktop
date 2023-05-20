namespace _2115229_NguyenNhatLinh_Lab06
{
    partial class frmFood
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
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.btnFoodDelete = new System.Windows.Forms.Button();
            this.btnFoodSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFood
            // 
            this.dgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(28, 25);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(550, 257);
            this.dgvFood.TabIndex = 0;
            // 
            // btnFoodDelete
            // 
            this.btnFoodDelete.Location = new System.Drawing.Point(637, 107);
            this.btnFoodDelete.Name = "btnFoodDelete";
            this.btnFoodDelete.Size = new System.Drawing.Size(75, 23);
            this.btnFoodDelete.TabIndex = 1;
            this.btnFoodDelete.Text = "Delete";
            this.btnFoodDelete.UseVisualStyleBackColor = true;
            this.btnFoodDelete.Click += new System.EventHandler(this.btnFoodDelete_Click);
            // 
            // btnFoodSave
            // 
            this.btnFoodSave.Location = new System.Drawing.Point(637, 61);
            this.btnFoodSave.Name = "btnFoodSave";
            this.btnFoodSave.Size = new System.Drawing.Size(75, 23);
            this.btnFoodSave.TabIndex = 2;
            this.btnFoodSave.Text = "Save";
            this.btnFoodSave.UseVisualStyleBackColor = true;
            this.btnFoodSave.Click += new System.EventHandler(this.btnFoodSave_Click);
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFoodSave);
            this.Controls.Add(this.btnFoodDelete);
            this.Controls.Add(this.dgvFood);
            this.Name = "frmFood";
            this.Text = "FoodForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Button btnFoodDelete;
        private System.Windows.Forms.Button btnFoodSave;
    }
}