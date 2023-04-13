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
            txtDescription = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 30);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "Product Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 92);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 162);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 221);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(233, 27);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(198, 39);
            txtProductCode.TabIndex = 4;
            txtProductCode.Tag = "Product code";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(233, 89);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(372, 39);
            txtDescription.TabIndex = 5;
            txtDescription.Tag = "Description";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(233, 159);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(150, 39);
            txtUnitPrice.TabIndex = 6;
            txtUnitPrice.Tag = "Price";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(233, 218);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 39);
            txtQuantity.TabIndex = 7;
            txtQuantity.Tag = "Quantity";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(476, 148);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 50);
            btnSave.TabIndex = 8;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(476, 207);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 50);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddModifyProduct
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(668, 319);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtProductCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
        private TextBox txtDescription;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private Button btnSave;
        private Button btnCancel;
    }
}