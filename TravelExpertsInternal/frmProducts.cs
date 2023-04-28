using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsDatas;

namespace TravelExpertsInternal
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void DisplayProducts()
        {
            dgvProducts.Rows.Clear();
            List<Product> products = ProductManager.GetAllProducts();
            //dgvProducts.DataSource = products;
            dgvProducts.Columns.Clear();
            dgvProducts.Columns.Add("ProductId", "Product ID");
            dgvProducts.Columns.Add("ProdName", "Product Name");
            dgvProducts.Columns[0].Width = 100;
            dgvProducts.Columns[1].Width = 200;
            foreach (Product product in products)
            {
                dgvProducts.Rows.Add(product.ProductId, product.ProdName);
            }
        }
    }
}
