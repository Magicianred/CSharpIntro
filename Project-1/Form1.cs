using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        string[] products = new string[] { "Laptop", "Pc", "Klavye" };

        private void Form1_Load(object sender, EventArgs e)
        {
            string productsText = "Ürünler:";
            var addToCartbuttonText = "Sepete Ekle";
            var removeFromCartbuttonText = "Sepetten Çıkar";
            string cartText = "Sepetiniz";
            lblProducts.Text = productsText;
            btnAddToCart.Text = addToCartbuttonText;
            btnRemove.Text = removeFromCartbuttonText;
            lbxCart.Text = cartText;
            btnRemove.Enabled = false;
            foreach (var item in products)
            {
                lbxProducts.Items.Add(item);
                
            }

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            
            if (lbxProducts.SelectedItem != null)
            {
                string selectedItemProducts = lbxProducts.SelectedItem.ToString();
                lbxCart.Items.Add(selectedItemProducts);
                lbxProducts.Items.Remove(selectedItemProducts);
                btnRemove.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin");
            }
            if (lbxProducts.Items.Count==0)
            {
                btnAddToCart.Enabled = false;
            }
        
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (lbxCart.SelectedItem != null)
            {
                string selectedItemfromCart = lbxCart.SelectedItem.ToString();
                lbxCart.Items.Remove(selectedItemfromCart);
                lbxProducts.Items.Add(selectedItemfromCart);
                btnAddToCart.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin");
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemove.Enabled = false;
            }
            
        }
    }
}
