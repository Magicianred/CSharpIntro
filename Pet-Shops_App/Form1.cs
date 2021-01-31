using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shops_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> products;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblProucts.Text = "Ürün Listesi";
            lblInCart.Text = "Sepetinizdeki Ürünler";
            label3.Text = "Eklenen ürünler.";
            label4.Text = "Silinen Ürünler";
            btnAdd.Text = "Ekle";
            btnRemove.Text = "Sil";


            products = new List<string> { "Kedi Kumu", "Köpek Maması", "Kedi Maması", "Köpek Tasması", "Kedi Tasması", "Mama Kabı" };

            foreach (var item in products)
            {
                lbxProducts.Items.Add(item);
            }


            btnRemove.Enabled = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem != null)
            {
                string selectedItem = lbxProducts.SelectedItem.ToString();
                lbxCart.Items.Add(selectedItem);
                lbxProducts.Items.Remove(selectedItem);
                btnRemove.Enabled = true;

                label3.Text += selectedItem + "\n ";

            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.");
            }
            if (lbxProducts.Items.Count == 0)
            {
                btnAdd.Enabled = false;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                string selectedItem = lbxCart.SelectedItem.ToString();
                lbxCart.Items.Remove(selectedItem);
                lbxProducts.Items.Add(selectedItem);
                btnAdd.Enabled = true;

                label4.Text += selectedItem + "\n";

            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.");
            }
            if (lbxCart.Items.Count == 0)
            {
                btnRemove.Enabled = false;
            }
        }
    }
}
