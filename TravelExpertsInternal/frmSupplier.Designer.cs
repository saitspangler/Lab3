namespace TravelExpertsInternal
{
    partial class frmSupplier
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
            this.dgvSuppliers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)this.dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new Point(12, 12);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.RowTemplate.Height = 25;
            this.dgvSuppliers.Size = new Size(776, 426);
            this.dgvSuppliers.TabIndex = 0;
            this.dgvSuppliers.CellClick += this.dgvSuppliers_CellClick_1;
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(this.dgvSuppliers);
            Name = "frmSupplier";
            Text = "frmSupplier";
            Load += frmSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)this.dgvSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        
    }
}