namespace TravelExpertsInternal
{
    partial class frmPackages
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
            dgvPackages = new DataGridView();
            btnAddPackage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // dgvPackages
            // 
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Location = new Point(12, 158);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowTemplate.Height = 25;
            dgvPackages.Size = new Size(1065, 380);
            dgvPackages.TabIndex = 0;
            dgvPackages.CellContentClick += dgvPackages_CellContentClick;
            // 
            // btnAddPackage
            // 
            btnAddPackage.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddPackage.Location = new Point(12, 34);
            btnAddPackage.Name = "btnAddPackage";
            btnAddPackage.Size = new Size(189, 57);
            btnAddPackage.TabIndex = 1;
            btnAddPackage.Text = "Add Package";
            btnAddPackage.UseVisualStyleBackColor = true;
            btnAddPackage.Click += btnAddPackage_Click;
            // 
            // frmPackages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 613);
            Controls.Add(btnAddPackage);
            Controls.Add(dgvPackages);
            Name = "frmPackages";
            Text = "frmPackages";
            Load += frmPackages_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPackages;
        private Button btnAddPackage;
    }
}