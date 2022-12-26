using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CKK.DB.Interfaces;
using CKK.Logic.Models;

namespace CKK.UI
{
    public partial class UserInput : Form
    {
        private IProductRepository Store;
        private Product? selectedItem;

        public UserInput(IProductRepository store, Product? item = null)
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
                Product newProduct = new Product();
                newProduct.Name = name;
                newProduct.Price = price;
                newProduct.Quantity = quantity;

                Store.Add(newProduct);
            } else
            {
                var productToUpdate = selectedItem;
                productToUpdate.Name = name;
                productToUpdate.Price = price;
                productToUpdate.Quantity = quantity;

                Store.Update(productToUpdate);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
