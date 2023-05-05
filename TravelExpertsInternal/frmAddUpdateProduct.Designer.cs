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
            lblAddUpdateProduct.Font = new Font("Cascadia Mono", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddUpdateProduct.Location = new Point(180, 20);
            lblAddUpdateProduct.Margin = new Padding(4, 0, 4, 0);
            lblAddUpdateProduct.Name = "lblAddUpdateProduct";
            lblAddUpdateProduct.Size = new Size(120, 27);
            lblAddUpdateProduct.TabIndex = 0;
            lblAddUpdateProduct.Text = "Text Here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 1;
            label1.Text = "Product Name:";
            // 
            // txtProdName
            // 
            txtProdName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProdName.Location = new Point(245, 75);
            txtProdName.Margin = new Padding(4);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(172, 29);
            txtProdName.TabIndex = 2;
            txtProdName.Tag = "Product Name";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(103, 199);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 35);
            btnSave.TabIndex = 3;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(274, 199);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 35);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddUpdateProduct
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(485, 284);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtProdName);
            Controls.Add(label1);
            Controls.Add(lblAddUpdateProduct);
            Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmAddUpdateProduct";
            Text = "Add Update Product";
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