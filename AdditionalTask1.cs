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
    public partial class AdditionalTask1 : Form
    {
        public AdditionalTask1()
        {
            InitializeComponent();
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            LoadFile();
            editButton.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(textBox1.Text);
            editForm.Show();
            editForm.Edit += EditForm_Edit;
        }

        private void EditForm_Edit(string obj)
        {
            textBox1.Text = obj;
        }

        private void LoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    textBox1.Text = reader.ReadToEnd();
                }
            }
        }
    }
}
