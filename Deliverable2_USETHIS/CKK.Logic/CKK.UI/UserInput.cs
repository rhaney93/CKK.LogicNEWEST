using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CKK.Logic.Models;

namespace CKK.UI
{
    public partial class UserInput : Form
    {
        private IStore Store;
        private StoreItem? selectedItem;

        public UserInput(IStore store, StoreItem? item = null)
        {
            Store = store;
            InitializeComponent();

            if (item != null)
            {
                this.selectedItem = item; 
                textBox_NameField.Text = item.Name;
                textBox_QuantityField.Text = item.Quantity.ToString();
                textBox_Price_Field.Text = item.Price.ToString();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string name = textBox_NameField.Text;
            int quantity = int.Parse(textBox_QuantityField.Text);
            decimal price = decimal.Parse(textBox_Price_Field.Text);

            if (selectedItem == null)
            {
                //Create a new constructor here for Product? 
                Product newProduct = new Product(price, name);
                Store.AddStoreItem(newProduct, quantity);
            } else
            {
                var productToUpdate = selectedItem.Product;
                productToUpdate.Name = name;
                productToUpdate.Price = price;
                Store.AddStoreItem(productToUpdate, quantity);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
