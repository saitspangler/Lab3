namespace ProductMaintenanceGUI
{
    partial class frmAddModifyProduct
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
            txtProductCode = new TextBox();
            txtName = new TextBox();
            txtVersion = new TextBox();
            txtReleaseDate = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 35);
            label1.Name = "label1";
            label1.Size = new Size(221, 30);
            label1.TabIndex = 0;
            label1.Text = "Product Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 116);
            label2.Name = "label2";
            label2.Size = new Size(93, 30);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 208);
            label3.Name = "label3";
            label3.Size = new Size(141, 30);
            label3.TabIndex = 2;
            label3.Text = "Version:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 292);
            label4.Name = "label4";
            label4.Size = new Size(221, 30);
            label4.TabIndex = 3;
            label4.Text = "Release Date:";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(387, 35);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(211, 37);
            txtProductCode.TabIndex = 4;
            txtProductCode.Tag = "Product code";
            // 
            // txtName
            // 
            txtName.Location = new Point(387, 116);
            txtName.Name = "txtName";
            txtName.Size = new Size(787, 37);
            txtName.TabIndex = 5;
            txtName.Tag = "Name";
            // 
            // txtVersion
            // 
            txtVersion.Location = new Point(387, 206);
            txtVersion.Name = "txtVersion";
            txtVersion.Size = new Size(232, 37);
            txtVersion.TabIndex = 6;
            txtVersion.Tag = "Version";
            // 
            // txtReleaseDate
            // 
            txtReleaseDate.Location = new Point(387, 292);
            txtReleaseDate.Name = "txtReleaseDate";
            txtReleaseDate.Size = new Size(515, 37);
            txtReleaseDate.TabIndex = 7;
            txtReleaseDate.Tag = "Release Date";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(54, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(271, 62);
            btnSave.TabIndex = 8;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(903, 369);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(271, 73);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddModifyProduct
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(16F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1332, 530);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtReleaseDate);
            Controls.Add(txtVersion);
            Controls.Add(txtName);
            Controls.Add(txtProductCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Liberation Mono", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmAddModifyProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddModifyProduct";
            Load += frmAddModifyProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProductCode;
        private TextBox txtName;
        private TextBox txtVersion;
        private TextBox txtReleaseDate;
        private Button btnSave;
        private Button btnCancel;
    }
}