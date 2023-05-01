namespace TravelExpertsInternal
{
    partial class frmAddModifySupplier
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
            txtSupplierId = new TextBox();
            txtSupName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 69);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 142);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(153, 67);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.ReadOnly = true;
            txtSupplierId.Size = new Size(100, 23);
            txtSupplierId.TabIndex = 2;
            // 
            // txtSupName
            // 
            txtSupName.Location = new Point(153, 144);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(204, 23);
            txtSupName.TabIndex = 3;
            // 
            // frmAddModifySupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSupName);
            Controls.Add(txtSupplierId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddModifySupplier";
            Text = "frmAddModifySupplier";
            Load += frmAddModifySupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSupplierId;
        private TextBox txtSupName;
    }
}