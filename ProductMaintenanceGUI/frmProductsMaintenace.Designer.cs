namespace ProductMaintenanceGUI
{
    partial class frmProductsMaintenace
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
            dgvProducts = new DataGridView();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(35, 35);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.RowTemplate.Height = 33;
            dgvProducts.Size = new Size(1098, 308);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(52, 365);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 41);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmProductsMaintenace
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 432);
            Controls.Add(btnAdd);
            Controls.Add(dgvProducts);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmProductsMaintenace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products Maintenance";
            Load += frmProductsMaintenace_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnAdd;
    }
}