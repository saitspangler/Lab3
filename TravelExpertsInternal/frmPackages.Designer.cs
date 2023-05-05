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
            btnBackHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // dgvPackages
            // 
            dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPackages.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Location = new Point(15, 155);
            dgvPackages.Margin = new Padding(4);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowTemplate.Height = 25;
            dgvPackages.Size = new Size(1369, 532);
            dgvPackages.TabIndex = 0;
            dgvPackages.CellContentClick += dgvPackages_CellContentClick;
            // 
            // btnAddPackage
            // 
            btnAddPackage.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddPackage.Location = new Point(15, 48);
            btnAddPackage.Margin = new Padding(4);
            btnAddPackage.Name = "btnAddPackage";
            btnAddPackage.Size = new Size(243, 80);
            btnAddPackage.TabIndex = 1;
            btnAddPackage.Text = "Add Package";
            btnAddPackage.UseVisualStyleBackColor = true;
            btnAddPackage.Click += btnAddPackage_Click;
            // 
            // btnBackHome
            // 
            btnBackHome.Location = new Point(1108, 48);
            btnBackHome.Margin = new Padding(4);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(276, 80);
            btnBackHome.TabIndex = 2;
            btnBackHome.Text = "Back";
            btnBackHome.UseVisualStyleBackColor = true;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // frmPackages
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 741);
            Controls.Add(btnBackHome);
            Controls.Add(btnAddPackage);
            Controls.Add(dgvPackages);
            Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmPackages";
            Text = "Packages";
            Load += frmPackages_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPackages;
        private Button btnAddPackage;
        private Button btnBackHome;
    }
}