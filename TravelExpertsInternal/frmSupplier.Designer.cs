﻿namespace TravelExpertsInternal
{
    partial class frmSupplier
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
            dgvSuppliers = new DataGridView();
            btnAddSupplier = new Button();
            btnExitSupplierPage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(12, 12);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowTemplate.Height = 25;
            dgvSuppliers.Size = new Size(554, 478);
            dgvSuppliers.TabIndex = 0;
            dgvSuppliers.CellContentClick += dgvSuppliers_CellContentClick;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(572, 12);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(161, 58);
            btnAddSupplier.TabIndex = 1;
            btnAddSupplier.Text = "Add Supplier";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // btnExitSupplierPage
            // 
            btnExitSupplierPage.Location = new Point(572, 432);
            btnExitSupplierPage.Name = "btnExitSupplierPage";
            btnExitSupplierPage.Size = new Size(161, 58);
            btnExitSupplierPage.TabIndex = 2;
            btnExitSupplierPage.Text = "Back";
            btnExitSupplierPage.UseVisualStyleBackColor = true;
            btnExitSupplierPage.Click += btnExitSupplierPage_Click;
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 502);
            Controls.Add(btnExitSupplierPage);
            Controls.Add(btnAddSupplier);
            Controls.Add(dgvSuppliers);
            Name = "frmSupplier";
            Text = "frmSupplier";
            Load += frmSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private Button btnAddSupplier;
        private Button btnExitSupplierPage;
    }
}