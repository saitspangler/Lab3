namespace TravelExpertsInternal
{
    partial class frmAddModifyPackage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPackageID = new TextBox();
            txtPkgName = new TextBox();
            txtPkgDesc = new TextBox();
            txtPkgStartDate = new TextBox();
            txtPkgEndDate = new TextBox();
            txtPkgBasePrice = new TextBox();
            txtAgencyCommission = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 68);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 117);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Package:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 166);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 219);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 3;
            label4.Text = "Start Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(273, 219);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 4;
            label5.Text = "End Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(51, 278);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 5;
            label6.Text = "Base Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(273, 278);
            label7.Name = "label7";
            label7.Size = new Size(155, 21);
            label7.TabIndex = 6;
            label7.Text = "Agency Commission:";
            // 
            // txtPackageID
            // 
            txtPackageID.Location = new Point(167, 70);
            txtPackageID.Name = "txtPackageID";
            txtPackageID.ReadOnly = true;
            txtPackageID.Size = new Size(100, 23);
            txtPackageID.TabIndex = 7;
            // 
            // txtPkgName
            // 
            txtPkgName.Location = new Point(167, 115);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(246, 23);
            txtPkgName.TabIndex = 8;
            // 
            // txtPkgDesc
            // 
            txtPkgDesc.Location = new Point(167, 164);
            txtPkgDesc.Name = "txtPkgDesc";
            txtPkgDesc.Size = new Size(246, 23);
            txtPkgDesc.TabIndex = 9;
            // 
            // txtPkgStartDate
            // 
            txtPkgStartDate.Location = new Point(138, 217);
            txtPkgStartDate.Name = "txtPkgStartDate";
            txtPkgStartDate.Size = new Size(100, 23);
            txtPkgStartDate.TabIndex = 10;
            // 
            // txtPkgEndDate
            // 
            txtPkgEndDate.Location = new Point(369, 217);
            txtPkgEndDate.Name = "txtPkgEndDate";
            txtPkgEndDate.Size = new Size(100, 23);
            txtPkgEndDate.TabIndex = 11;
            // 
            // txtPkgBasePrice
            // 
            txtPkgBasePrice.Location = new Point(138, 276);
            txtPkgBasePrice.Name = "txtPkgBasePrice";
            txtPkgBasePrice.Size = new Size(100, 23);
            txtPkgBasePrice.TabIndex = 12;
            // 
            // txtAgencyCommission
            // 
            txtAgencyCommission.Location = new Point(447, 276);
            txtAgencyCommission.Name = "txtAgencyCommission";
            txtAgencyCommission.Size = new Size(100, 23);
            txtAgencyCommission.TabIndex = 13;
            // 
            // frmAddModifyPackage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAgencyCommission);
            Controls.Add(txtPkgBasePrice);
            Controls.Add(txtPkgEndDate);
            Controls.Add(txtPkgStartDate);
            Controls.Add(txtPkgDesc);
            Controls.Add(txtPkgName);
            Controls.Add(txtPackageID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddModifyPackage";
            Text = "frmAddModifyPackage";
            Load += frmAddModifyPackage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPackageID;
        private TextBox txtPkgName;
        private TextBox txtPkgDesc;
        private TextBox txtPkgStartDate;
        private TextBox txtPkgEndDate;
        private TextBox txtPkgBasePrice;
        private TextBox txtAgencyCommission;
    }
}