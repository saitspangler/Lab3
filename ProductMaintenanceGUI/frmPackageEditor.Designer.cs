namespace ProductMaintenanceGUI
{
    partial class frmPackageEditor
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
            dgvProducts = new DataGridView();
            groupBox1 = new GroupBox();
            rdoPackages = new RadioButton();
            rdoProducts = new RadioButton();
            rdoSuppliers = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(49, 277);
            dgvProducts.Margin = new Padding(3, 2, 3, 2);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.RowTemplate.Height = 33;
            dgvProducts.Size = new Size(925, 315);
            dgvProducts.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoSuppliers);
            groupBox1.Controls.Add(rdoProducts);
            groupBox1.Controls.Add(rdoPackages);
            groupBox1.Location = new Point(49, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rdoPackages
            // 
            rdoPackages.AutoSize = true;
            rdoPackages.Location = new Point(6, 50);
            rdoPackages.Name = "rdoPackages";
            rdoPackages.Size = new Size(91, 25);
            rdoPackages.TabIndex = 0;
            rdoPackages.TabStop = true;
            rdoPackages.Text = "Packages";
            rdoPackages.UseVisualStyleBackColor = true;
            // 
            // rdoProducts
            // 
            rdoProducts.AutoSize = true;
            rdoProducts.Location = new Point(148, 50);
            rdoProducts.Name = "rdoProducts";
            rdoProducts.Size = new Size(89, 25);
            rdoProducts.TabIndex = 1;
            rdoProducts.TabStop = true;
            rdoProducts.Text = "Products";
            rdoProducts.UseVisualStyleBackColor = true;
            // 
            // rdoSuppliers
            // 
            rdoSuppliers.AutoSize = true;
            rdoSuppliers.Location = new Point(298, 50);
            rdoSuppliers.Name = "rdoSuppliers";
            rdoSuppliers.Size = new Size(93, 25);
            rdoSuppliers.TabIndex = 2;
            rdoSuppliers.TabStop = true;
            rdoSuppliers.Text = "Suppliers";
            rdoSuppliers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(49, 64);
            button1.Name = "button1";
            button1.Size = new Size(135, 50);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(197, 64);
            button2.Name = "button2";
            button2.Size = new Size(135, 50);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(347, 64);
            button3.Name = "button3";
            button3.Size = new Size(135, 50);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmPackageEditor
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(dgvProducts);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmPackageEditor";
            Text = "frmPackageEditor";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private GroupBox groupBox1;
        private RadioButton rdoSuppliers;
        private RadioButton rdoProducts;
        private RadioButton rdoPackages;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}