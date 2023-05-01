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
            ((System.ComponentModel.ISupportInitialize)dgvPackageProductList).BeginInit();
            SuspendLayout();
            // 
            // dgvPackageProductList
            // 
            dgvPackageProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackageProductList.Location = new Point(12, 24);
            dgvPackageProductList.Name = "dgvPackageProductList";
            dgvPackageProductList.RowTemplate.Height = 25;
            dgvPackageProductList.Size = new Size(537, 320);
            dgvPackageProductList.TabIndex = 0;
            // 
            // btnSavePackage
            // 
            btnSavePackage.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSavePackage.Location = new Point(595, 24);
            btnSavePackage.Name = "btnSavePackage";
            btnSavePackage.Size = new Size(139, 75);
            btnSavePackage.TabIndex = 1;
            btnSavePackage.Text = "Save Package";
            btnSavePackage.UseVisualStyleBackColor = true;
            btnSavePackage.Click += btnSavePackage_Click;
            // 
            // frmAddUpdatePackages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSavePackage);
            Controls.Add(dgvPackageProductList);
            Name = "frmAddUpdatePackages";
            Text = "frmAddUpdatePackages";
            Load += frmAddUpdatePackages_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPackageProductList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPackageProductList;
        private Button btnSavePackage;
    }
}