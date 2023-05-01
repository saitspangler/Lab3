﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using TravelExpertsDatas;

namespace TravelExpertsInternal
{
    public partial class frmAddModifyProduct : Form
    {
        public Product Product { get; set; }
        public bool AddProduct { get; set; }

        public frmAddModifyProduct()
        {
            InitializeComponent();
        }

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            if (AddProduct)
            {
                this.Text = "Add Product";
                txtProductId.ReadOnly = false;  // allow entry of new product code
            }
            else
            {
                this.Text = "Modify Product";
                txtProductId.ReadOnly = true;   // can't change existing product code
                this.DisplayProduct();
            }
        }

        private void DisplayProduct()
        {
            txtProductId.Text = Product.ProductId.ToString();
            txtProdName.Text = Product.ProdName;
        }



        //private void frmAddModifyProduct_Load(object sender, EventArgs e)
        //{
        //    if (AddProduct)
        //    {
        //        this.Text = "Add Product";
        //        txtCode.ReadOnly = false;  // allow entry of new product code
        //    }
        //    else
        //    {
        //        this.Text = "Modify Product";
        //        txtCode.ReadOnly = true;   // can't change existing product code
        //        this.DisplayProduct();
        //    }
        //}

        //private void DisplayProduct()
        //{
        //    txtCode.Text = Product.ProductCode;
        //    txtDescription.Text = Product.Description;
        //    txtPrice.Text = Product.UnitPrice.ToString("N2");
        //}

        //private void btnAccept_Click(object sender, EventArgs e)
        //{
        //    if (IsValidData())
        //    {
        //        if (AddProduct)
        //        {
        //            // initialize the Product property with new Products object
        //            this.Product = new Products();
        //        }
        //        this.LoadProductData();
        //        this.DialogResult = DialogResult.OK;
        //    }
        //}
        //private bool IsValidData()
        //{
        //    bool success = true;
        //    string errorMessage = "";

        //    errorMessage += Validator.IsPresent(txtCode.Text, txtCode.Tag.ToString());
        //    errorMessage += Validator.IsPresent(txtDescription.Text, txtDescription.Tag.ToString());
        //    errorMessage += Validator.IsPresent(txtPrice.Text, txtPrice.Tag.ToString());
        //    errorMessage += Validator.IsDecimal(txtPrice.Text, txtPrice.Tag.ToString());

        //    if (errorMessage != "")
        //    {
        //        success = false;
        //        MessageBox.Show(errorMessage, "Entry Error");
        //    }
        //    return success;
        //}

        //private void LoadProductData()
        //{
        //    Product.ProductCode = txtCode.Text;
        //    Product.Description = txtDescription.Text;
        //    Product.UnitPrice = Convert.ToDecimal(txtPrice.Text);
        //    //Product.OnHandQuantity = Convert.ToInt32(txtOnHand.Text);
        //}
    }
}
