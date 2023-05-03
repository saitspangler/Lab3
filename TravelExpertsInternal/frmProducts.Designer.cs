namespace TravelExpertsInternal
{
    partial class frmProducts
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
            btnAdd = new Button();
            btnExitProductsPage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 12);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(776, 351);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 389);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 38);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExitProductsPage
            // 
            btnExitProductsPage.Location = new Point(667, 389);
            btnExitProductsPage.Name = "btnExitProductsPage";
            btnExitProductsPage.Size = new Size(121, 38);
            btnExitProductsPage.TabIndex = 2;
            btnExitProductsPage.Text = "Back";
            btnExitProductsPage.UseVisualStyleBackColor = true;
            btnExitProductsPage.Click += btnExitProductsPage_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitProductsPage);
            Controls.Add(btnAdd);
            Controls.Add(dgvProducts);
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnAdd;
        private Button btnExitProductsPage;
    }
}