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
            btnSavePackage = new Button();
            cbSuppliers = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnAddToPackage = new Button();
            label3 = new Label();
            lbAddProductList = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            txtPackageName = new TextBox();
            txtPackagePrice = new TextBox();
            txtPackageAgencyCommission = new TextBox();
            txtPackageDescription = new TextBox();
            lbPackageProductList = new ListBox();
            btnCancelAdd = new Button();
            SuspendLayout();
            // 
            // btnSavePackage
            // 
            btnSavePackage.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSavePackage.Location = new Point(959, 601);
            btnSavePackage.Margin = new Padding(4);
            btnSavePackage.Name = "btnSavePackage";
            btnSavePackage.Size = new Size(179, 105);
            btnSavePackage.TabIndex = 1;
            btnSavePackage.Text = "Save Package";
            btnSavePackage.UseVisualStyleBackColor = true;
            btnSavePackage.Click += btnSavePackage_Click;
            // 
            // cbSuppliers
            // 
            cbSuppliers.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbSuppliers.FormattingEnabled = true;
            cbSuppliers.Location = new Point(463, 389);
            cbSuppliers.Margin = new Padding(4);
            cbSuppliers.Name = "cbSuppliers";
            cbSuppliers.Size = new Size(277, 24);
            cbSuppliers.TabIndex = 2;
            cbSuppliers.SelectedIndexChanged += cbSuppliers_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(514, 347);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 3;
            label1.Text = "Choose Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 330);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 5;
            label2.Text = "Current Package";
            // 
            // btnAddToPackage
            // 
            btnAddToPackage.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddToPackage.Location = new Point(511, 429);
            btnAddToPackage.Margin = new Padding(4);
            btnAddToPackage.Name = "btnAddToPackage";
            btnAddToPackage.Size = new Size(179, 102);
            btnAddToPackage.TabIndex = 6;
            btnAddToPackage.Text = "<< Add To Package";
            btnAddToPackage.UseVisualStyleBackColor = true;
            btnAddToPackage.Click += btnAddToPackage_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(901, 309);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 7;
            label3.Text = "Product List";
            // 
            // lbAddProductList
            // 
            lbAddProductList.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbAddProductList.FormattingEnabled = true;
            lbAddProductList.ItemHeight = 20;
            lbAddProductList.Location = new Point(800, 347);
            lbAddProductList.Margin = new Padding(4);
            lbAddProductList.Name = "lbAddProductList";
            lbAddProductList.Size = new Size(355, 184);
            lbAddProductList.TabIndex = 8;
            lbAddProductList.SelectedIndexChanged += lbAddProductList_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 24);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 9;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 92);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 10;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(720, 49);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 11;
            label6.Text = "Base Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(959, 49);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(163, 21);
            label7.TabIndex = 12;
            label7.Text = "Agency Commission";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(559, 179);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 21);
            label8.TabIndex = 13;
            label8.Text = "Start Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(976, 179);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 21);
            label9.TabIndex = 14;
            label9.Text = "End Date";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(850, 221);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(305, 26);
            dtpEndDate.TabIndex = 15;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(476, 221);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(313, 26);
            dtpStartDate.TabIndex = 16;
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(38, 49);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(348, 26);
            txtPackageName.TabIndex = 17;
            // 
            // txtPackagePrice
            // 
            txtPackagePrice.Location = new Point(686, 87);
            txtPackagePrice.Name = "txtPackagePrice";
            txtPackagePrice.Size = new Size(172, 26);
            txtPackagePrice.TabIndex = 18;
            // 
            // txtPackageAgencyCommission
            // 
            txtPackageAgencyCommission.Location = new Point(976, 87);
            txtPackageAgencyCommission.Name = "txtPackageAgencyCommission";
            txtPackageAgencyCommission.Size = new Size(146, 26);
            txtPackageAgencyCommission.TabIndex = 19;
            // 
            // txtPackageDescription
            // 
            txtPackageDescription.Location = new Point(38, 116);
            txtPackageDescription.Multiline = true;
            txtPackageDescription.Name = "txtPackageDescription";
            txtPackageDescription.Size = new Size(348, 165);
            txtPackageDescription.TabIndex = 20;
            // 
            // lbPackageProductList
            // 
            lbPackageProductList.FormattingEnabled = true;
            lbPackageProductList.ItemHeight = 21;
            lbPackageProductList.Location = new Point(38, 371);
            lbPackageProductList.Name = "lbPackageProductList";
            lbPackageProductList.Size = new Size(328, 151);
            lbPackageProductList.TabIndex = 21;
            // 
            // btnCancelAdd
            // 
            btnCancelAdd.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelAdd.Location = new Point(38, 635);
            btnCancelAdd.Margin = new Padding(4);
            btnCancelAdd.Name = "btnCancelAdd";
            btnCancelAdd.Size = new Size(179, 105);
            btnCancelAdd.TabIndex = 22;
            btnCancelAdd.Text = "Cancel";
            btnCancelAdd.UseVisualStyleBackColor = true;
            btnCancelAdd.Click += btnCancelAdd_Click;
            // 
            // frmAddUpdatePackages
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 805);
            Controls.Add(btnCancelAdd);
            Controls.Add(lbPackageProductList);
            Controls.Add(txtPackageDescription);
            Controls.Add(txtPackageAgencyCommission);
            Controls.Add(txtPackagePrice);
            Controls.Add(txtPackageName);
            Controls.Add(dtpStartDate);
            Controls.Add(dtpEndDate);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbAddProductList);
            Controls.Add(label3);
            Controls.Add(btnAddToPackage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSuppliers);
            Controls.Add(btnSavePackage);
            Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmAddUpdatePackages";
            Text = "frmAddUpdatePackages";
            Load += frmAddUpdatePackages_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSavePackage;
        private ComboBox cbSuppliers;
        private Label label1;
        private Label label2;
        private Button btnAddToPackage;
        private Label label3;
        private ListBox lbAddProductList;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private TextBox txtPackageName;
        private TextBox txtPackagePrice;
        private TextBox txtPackageAgencyCommission;
        private TextBox txtPackageDescription;
        private ListBox lbPackageProductList;
        private Button btnCancelAdd;
    }
}