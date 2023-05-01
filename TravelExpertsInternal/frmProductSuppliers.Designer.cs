namespace TravelExpertsInternal
{
    partial class frmProductSuppliers
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
            dgvProductSuppliers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dgvProductSuppliers
            // 
            dgvProductSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductSuppliers.Location = new Point(12, 12);
            dgvProductSuppliers.Name = "dgvProductSuppliers";
            dgvProductSuppliers.RowTemplate.Height = 25;
            dgvProductSuppliers.Size = new Size(776, 426);
            dgvProductSuppliers.TabIndex = 0;
            dgvProductSuppliers.CellClick += dgvProductSuppliers_CellClick;
            // 
            // frmProductSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProductSuppliers);
            Name = "frmProductSuppliers";
            Text = "frmProductSuppliers";
            Load += frmProductSuppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductSuppliers;
    }
}