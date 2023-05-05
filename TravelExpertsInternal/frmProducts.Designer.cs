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
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(15, 16);
            dgvProducts.Margin = new Padding(4);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(998, 468);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 519);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 51);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(854, 519);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(159, 51);
            btnBack.TabIndex = 2;
            btnBack.Text = "&Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBack;
            ClientSize = new Size(1029, 600);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(dgvProducts);
            Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmProducts";
            Text = "Products";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnAdd;
        private Button btnBack;

    }
}