namespace TravelExpertsInternal
{
    partial class frmAddUpdatePackages
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
            dgvPackageProductList = new DataGridView();
            btnSavePackage = new Button();
            cbSuppliers = new ComboBox();
            label1 = new Label();
            dgvAddProductsList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPackageProductList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddProductsList).BeginInit();
            SuspendLayout();
            // 
            // dgvPackageProductList
            // 
            dgvPackageProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackageProductList.Location = new Point(12, 70);
            dgvPackageProductList.Name = "dgvPackageProductList";
            dgvPackageProductList.RowTemplate.Height = 25;
            dgvPackageProductList.Size = new Size(343, 320);
            dgvPackageProductList.TabIndex = 0;
            // 
            // btnSavePackage
            // 
            btnSavePackage.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSavePackage.Location = new Point(413, 315);
            btnSavePackage.Name = "btnSavePackage";
            btnSavePackage.Size = new Size(139, 75);
            btnSavePackage.TabIndex = 1;
            btnSavePackage.Text = "Save Package";
            btnSavePackage.UseVisualStyleBackColor = true;
            btnSavePackage.Click += btnSavePackage_Click;
            // 
            // cbSuppliers
            // 
            cbSuppliers.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbSuppliers.FormattingEnabled = true;
            cbSuppliers.Location = new Point(380, 70);
            cbSuppliers.Name = "cbSuppliers";
            cbSuppliers.Size = new Size(216, 24);
            cbSuppliers.TabIndex = 2;
            cbSuppliers.SelectedIndexChanged += cbSuppliers_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(413, 20);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 3;
            label1.Text = "Choose Supplier";
            // 
            // dgvAddProductsList
            // 
            dgvAddProductsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddProductsList.Location = new Point(624, 70);
            dgvAddProductsList.Name = "dgvAddProductsList";
            dgvAddProductsList.RowTemplate.Height = 25;
            dgvAddProductsList.Size = new Size(284, 320);
            dgvAddProductsList.TabIndex = 4;
            dgvAddProductsList.CellContentClick += dgvAddProductsList_CellContentClick;
            // 
            // frmAddUpdatePackages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 450);
            Controls.Add(dgvAddProductsList);
            Controls.Add(label1);
            Controls.Add(cbSuppliers);
            Controls.Add(btnSavePackage);
            Controls.Add(dgvPackageProductList);
            Name = "frmAddUpdatePackages";
            Text = "frmAddUpdatePackages";
            Load += frmAddUpdatePackages_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPackageProductList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddProductsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPackageProductList;
        private Button btnSavePackage;
        private ComboBox cbSuppliers;
        private Label label1;
        private DataGridView dgvAddProductsList;
    }
}