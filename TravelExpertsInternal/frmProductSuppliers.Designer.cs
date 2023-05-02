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
            btnAdd = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dgvProductSuppliers
            // 
            dgvProductSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductSuppliers.Location = new Point(15, 80);
            dgvProductSuppliers.Margin = new Padding(4, 4, 4, 4);
            dgvProductSuppliers.Name = "dgvProductSuppliers";
            dgvProductSuppliers.RowTemplate.Height = 25;
            dgvProductSuppliers.Size = new Size(934, 226);
            dgvProductSuppliers.TabIndex = 0;
            dgvProductSuppliers.CellClick += dgvProductSuppliers_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(108, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(236, 36);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "&Add New Products Supplier";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(781, 21);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 36);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "&Back";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmProductSuppliers
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(981, 356);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(dgvProductSuppliers);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmProductSuppliers";
            Text = "frmProductSuppliers";
            Load += frmProductSuppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductSuppliers;
        private Button btnAdd;
        private Button btnCancel;
    }
}