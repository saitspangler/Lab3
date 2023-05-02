namespace TravelExpertsInternal
{
    partial class frmAddUpdateProduct
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
            lblAddUpdateProduct = new Label();
            label1 = new Label();
            txtProdName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblAddUpdateProduct
            // 
            lblAddUpdateProduct.AutoSize = true;
            lblAddUpdateProduct.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddUpdateProduct.Location = new Point(142, 45);
            lblAddUpdateProduct.Name = "lblAddUpdateProduct";
            lblAddUpdateProduct.Size = new Size(92, 28);
            lblAddUpdateProduct.TabIndex = 0;
            lblAddUpdateProduct.Text = "Text Here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 143);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 1;
            label1.Text = "Product Name:";
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(189, 143);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(135, 23);
            txtProdName.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(39, 217);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 39);
            btnSave.TabIndex = 3;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(211, 217);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 39);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddUpdateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(377, 340);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtProdName);
            Controls.Add(label1);
            Controls.Add(lblAddUpdateProduct);
            Name = "frmAddUpdateProduct";
            Text = "frmAddUpdateProduct";
            Load += frmAddUpdateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddUpdateProduct;
        private Label label1;
        private TextBox txtProdName;
        private Button btnSave;
        private Button btnCancel;
    }
}