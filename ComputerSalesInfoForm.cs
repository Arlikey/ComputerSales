using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerSales
{
    public partial class ComputerSalesInfoForm : Form
    {
        public ComputerSalesInfoForm(Product[] products)
        {
            InitializeComponent();
            productsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDataGridView.DataSource = products;
        }
    }
}
