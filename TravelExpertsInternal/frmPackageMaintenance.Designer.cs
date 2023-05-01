namespace TravelExpertsInternal
{
    partial class frmPackageMaintenance
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
            dgvDisplay = new DataGridView();
            groupBox1 = new GroupBox();
            rdoProducts = new RadioButton();
            rdoSuppliers = new RadioButton();
            rdoPackages = new RadioButton();
            btnAddPackage = new Button();
            btnAddProduct = new Button();
            btnAddSupplier = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDisplay
            // 
            dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplay.Location = new Point(13, 303);
            dgvDisplay.Margin = new Padding(4);
            dgvDisplay.Name = "dgvDisplay";
            dgvDisplay.RowTemplate.Height = 25;
            dgvDisplay.Size = new Size(998, 389);
            dgvDisplay.TabIndex = 1;
            dgvDisplay.CellClick += dgvDisplay_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoProducts);
            groupBox1.Controls.Add(rdoSuppliers);
            groupBox1.Controls.Add(rdoPackages);
            groupBox1.Location = new Point(13, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 126);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rdoProducts
            // 
            rdoProducts.AutoSize = true;
            rdoProducts.Location = new Point(162, 60);
            rdoProducts.Name = "rdoProducts";
            rdoProducts.Size = new Size(89, 25);
            rdoProducts.TabIndex = 4;
            rdoProducts.Text = "Products";
            rdoProducts.UseVisualStyleBackColor = true;
            rdoProducts.CheckedChanged += rdoProducts_CheckedChanged;
            // 
            // rdoSuppliers
            // 
            rdoSuppliers.AutoSize = true;
            rdoSuppliers.Location = new Point(319, 60);
            rdoSuppliers.Name = "rdoSuppliers";
            rdoSuppliers.Size = new Size(93, 25);
            rdoSuppliers.TabIndex = 5;
            rdoSuppliers.Text = "Suppliers";
            rdoSuppliers.UseVisualStyleBackColor = true;
            rdoSuppliers.CheckedChanged += rdoSuppliers_CheckedChanged;
            // 
            // rdoPackages
            // 
            rdoPackages.AutoSize = true;
            rdoPackages.Checked = true;
            rdoPackages.Location = new Point(16, 60);
            rdoPackages.Name = "rdoPackages";
            rdoPackages.Size = new Size(91, 25);
            rdoPackages.TabIndex = 3;
            rdoPackages.TabStop = true;
            rdoPackages.Text = "Packages";
            rdoPackages.UseVisualStyleBackColor = true;
            rdoPackages.CheckedChanged += rdoPackages_CheckedChanged;
            // 
            // btnAddPackage
            // 
            btnAddPackage.Location = new Point(598, 57);
            btnAddPackage.Name = "btnAddPackage";
            btnAddPackage.Size = new Size(151, 53);
            btnAddPackage.TabIndex = 3;
            btnAddPackage.Text = "&AddPkg";
            btnAddPackage.UseVisualStyleBackColor = true;
            btnAddPackage.Click += btnAddPackage_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(800, 57);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(151, 53);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "&AddPrdct";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(598, 161);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(151, 53);
            btnAddSupplier.TabIndex = 5;
            btnAddSupplier.Text = "&AddSplr";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // frmPackageMaintenance
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 725);
            Controls.Add(btnAddSupplier);
            Controls.Add(btnAddProduct);
            Controls.Add(btnAddPackage);
            Controls.Add(groupBox1);
            Controls.Add(dgvDisplay);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmPackageMaintenance";
            Text = "frmPackageMaintenance";
            Load += frmPackageMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDisplay;
        private GroupBox groupBox1;
        private RadioButton rdoProducts;
        private RadioButton rdoSuppliers;
        private RadioButton rdoPackages;
        private Button btnAddPackage;
        private Button btnAddProduct;
        private Button btnAddSupplier;
    }
}