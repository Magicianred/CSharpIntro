using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> petShop;
        private void Form1_Load(object sender, EventArgs e)
        {
            petShop = new List<string>() { "Kum", "Mama", "Oyuncak" };
            foreach (var item in petShop)
            {
                lbxProductsList.Items.Add(item);
            }
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            if (tbxProductsName.Text.Length > 1)
            {
                petShop.Add(tbxProductsName.Text);
                lbxProductsList.Items.Clear();
                foreach (var item in petShop)
                {
                    lbxProductsList.Items.Add(item);
                }
                tbxProductsName.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün adı giriniz.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxProductsList.SelectedItem != null)
            {
                int selected = lbxProductsList.SelectedIndex;
                petShop.RemoveAt(selected);
                lbxProductsList.Items.Clear();
                foreach (var item in petShop)
                {
                    lbxProductsList.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.");
            }
        }
    }
}
