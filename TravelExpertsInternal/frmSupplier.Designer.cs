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
            dgvSuppliers = new DataGridView();
            btnAddSupplier = new Button();
            btnExitSupplierPage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(15, 16);
            dgvSuppliers.Margin = new Padding(4, 4, 4, 4);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowTemplate.Height = 25;
            dgvSuppliers.Size = new Size(712, 638);
            dgvSuppliers.TabIndex = 0;
            dgvSuppliers.CellContentClick += dgvSuppliers_CellContentClick;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(735, 16);
            btnAddSupplier.Margin = new Padding(4, 4, 4, 4);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(207, 78);
            btnAddSupplier.TabIndex = 1;
            btnAddSupplier.Text = "Add Supplier";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // btnExitSupplierPage
            // 
            btnExitSupplierPage.Location = new Point(735, 576);
            btnExitSupplierPage.Margin = new Padding(4, 4, 4, 4);
            btnExitSupplierPage.Name = "btnExitSupplierPage";
            btnExitSupplierPage.Size = new Size(207, 78);
            btnExitSupplierPage.TabIndex = 2;
            btnExitSupplierPage.Text = "Back";
            btnExitSupplierPage.UseVisualStyleBackColor = true;
            btnExitSupplierPage.Click += btnExitSupplierPage_Click;
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 669);
            Controls.Add(btnExitSupplierPage);
            Controls.Add(btnAddSupplier);
            Controls.Add(dgvSuppliers);
            Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmSupplier";
            Text = "frmSupplier";
            Load += frmSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private Button btnAddSupplier;
        private Button btnExitSupplierPage;
    }
}