namespace TravelExpertsInternal
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnAddPackages = new Button();
            btnProducts = new Button();
            btnProductSuppliers = new Button();
            btnSuppliers = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(392, 80);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(271, 21);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Travel Experts Package Editor";
            // 
            // btnAddPackages
            // 
            btnAddPackages.Location = new Point(70, 177);
            btnAddPackages.Name = "btnAddPackages";
            btnAddPackages.Size = new Size(203, 62);
            btnAddPackages.TabIndex = 1;
            btnAddPackages.Text = "Add / Update Packages";
            btnAddPackages.UseVisualStyleBackColor = true;
            btnAddPackages.Click += btnAddPackages_Click;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(354, 177);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(203, 62);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnProductSuppliers
            // 
            btnProductSuppliers.Location = new Point(840, 177);
            btnProductSuppliers.Name = "btnProductSuppliers";
            btnProductSuppliers.Size = new Size(203, 62);
            btnProductSuppliers.TabIndex = 3;
            btnProductSuppliers.Text = "Product Suppliers";
            btnProductSuppliers.UseVisualStyleBackColor = true;
            btnProductSuppliers.Click += btnProductSuppliers_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(599, 177);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(203, 62);
            btnSuppliers.TabIndex = 4;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 630);
            Controls.Add(btnSuppliers);
            Controls.Add(btnProductSuppliers);
            Controls.Add(btnProducts);
            Controls.Add(btnAddPackages);
            Controls.Add(lblWelcome);
            Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Start";
            Text = "Start";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnAddPackages;
        private Button btnProducts;
        private Button btnProductSuppliers;
        private Button btnSuppliers;
    }
}