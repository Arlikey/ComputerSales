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
    public partial class EditForm : Form
    {
        public event Action<string> Edit;
        public EditForm(string content)
        {
            InitializeComponent();
            textBox1.Text = content;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Edit?.Invoke(textBox1.Text);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
