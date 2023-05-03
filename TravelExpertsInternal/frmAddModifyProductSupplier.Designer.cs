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
            label2 = new Label();
            label3 = new Label();
            cboProductID = new ComboBox();
            cboSupplierID = new ComboBox();
            btnAccept = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 56);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 1;
            label2.Text = "Product:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 92);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 2;
            label3.Text = "Supplier:";
            // 
            // cboProductID
            // 
            cboProductID.FormattingEnabled = true;
            cboProductID.Location = new Point(142, 53);
            cboProductID.Name = "cboProductID";
            cboProductID.Size = new Size(224, 29);
            cboProductID.TabIndex = 3;
            // 
            // cboSupplierID
            // 
            cboSupplierID.FormattingEnabled = true;
            cboSupplierID.Location = new Point(142, 89);
            cboSupplierID.Name = "cboSupplierID";
            cboSupplierID.Size = new Size(224, 29);
            cboSupplierID.TabIndex = 4;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(74, 150);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 38);
            btnAccept.TabIndex = 6;
            btnAccept.Text = "&Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(319, 150);
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
            ClientSize = new Size(447, 245);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(cboSupplierID);
            Controls.Add(cboProductID);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmAddModifyProductSupplier";
            Text = "frmAddModifyProductSupplier";
            Load += frmAddModifyProductSupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private ComboBox cboProductID;
        private ComboBox cboSupplierID;
        private Button btnAccept;
        private Button btnCancel;
    }
}