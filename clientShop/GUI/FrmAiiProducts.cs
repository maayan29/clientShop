using clientShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientShop.GUI
{
    public partial class FrmAllProducts : Form
    {
        Connect con;
        List<Products> lstproducts;
        public FrmAllProducts()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmAllProducts_Load(object sender, EventArgs e)
        {
            lstproducts = await con.GetAllProducts();
            dgvAllProducts.DataSource = lstproducts.Select(p => new
            {
                p.ProductId,
                p.ProductName,
                p.Category,
                p.Material,
                p.Price,
            }).ToList();
            dgvAllProducts.Columns[0].

        }

    }
}
