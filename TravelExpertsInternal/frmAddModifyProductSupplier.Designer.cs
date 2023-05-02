namespace TravelExpertsInternal
{
    partial class frmAddModifyProductSupplier
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
            cboProductID = new ComboBox();
            cboSupplierID = new ComboBox();
            txtProductsSupplierID = new TextBox();
            btnAccept = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 0;
            label1.Text = "Products Supplier ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 52);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "Product ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 88);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 2;
            label3.Text = "Supplier ID:";
            // 
            // cboProductID
            // 
            cboProductID.FormattingEnabled = true;
            cboProductID.Location = new Point(170, 49);
            cboProductID.Name = "cboProductID";
            cboProductID.Size = new Size(121, 29);
            cboProductID.TabIndex = 3;
            // 
            // cboSupplierID
            // 
            cboSupplierID.FormattingEnabled = true;
            cboSupplierID.Location = new Point(170, 85);
            cboSupplierID.Name = "cboSupplierID";
            cboSupplierID.Size = new Size(121, 29);
            cboSupplierID.TabIndex = 4;
            // 
            // txtProductsSupplierID
            // 
            txtProductsSupplierID.Location = new Point(170, 12);
            txtProductsSupplierID.Name = "txtProductsSupplierID";
            txtProductsSupplierID.ReadOnly = true;
            txtProductsSupplierID.Size = new Size(121, 29);
            txtProductsSupplierID.TabIndex = 5;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(64, 119);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 38);
            btnAccept.TabIndex = 6;
            btnAccept.Text = "&Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(228, 120);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 38);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddModifyProductSupplier
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(335, 172);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtProductsSupplierID);
            Controls.Add(cboSupplierID);
            Controls.Add(cboProductID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmAddModifyProductSupplier";
            Text = "frmAddModifyProductSupplier";
            Load += frmAddModifyProductSupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboProductID;
        private ComboBox cboSupplierID;
        private TextBox txtProductsSupplierID;
        private Button btnAccept;
        private Button btnCancel;
    }
}