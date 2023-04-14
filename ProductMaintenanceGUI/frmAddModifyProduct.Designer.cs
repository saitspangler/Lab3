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
            label1.Location = new Point(51, 26);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Product Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 88);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 155);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Version:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 210);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 3;
            label4.Text = "Release Date:";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(233, 26);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(198, 25);
            txtProductCode.TabIndex = 4;
            txtProductCode.Tag = "Product code";
            // 
            // txtName
            // 
            txtName.Location = new Point(233, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(372, 25);
            txtName.TabIndex = 5;
            txtName.Tag = "Description";
            // 
            // txtVersion
            // 
            txtVersion.Location = new Point(233, 151);
            txtVersion.Name = "txtVersion";
            txtVersion.Size = new Size(150, 25);
            txtVersion.TabIndex = 6;
            txtVersion.Tag = "Price";
            // 
            // txtReleaseDate
            // 
            txtReleaseDate.Location = new Point(233, 208);
            txtReleaseDate.Name = "txtReleaseDate";
            txtReleaseDate.Size = new Size(150, 25);
            txtReleaseDate.TabIndex = 7;
            txtReleaseDate.Tag = "Quantity";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(476, 141);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 48);
            btnSave.TabIndex = 8;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(476, 197);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 48);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddModifyProduct
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(668, 304);
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
            Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
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