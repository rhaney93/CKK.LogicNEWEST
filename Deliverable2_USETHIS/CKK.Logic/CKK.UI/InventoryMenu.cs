using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CKK.Logic.Models;
using CKK.Persistance.Models;

namespace CKK.UI
{
    public partial class InventoryMenu : Form
    {
        private FileStore Store;

        private int selectedIndex = -1;
        private StoreItem? selectedItem
        {
            get { 
                if (selectedIndex >= 0)
                {
                    return this.Items[selectedIndex];
                }

                return null;
            }
        }
        

        public List<StoreItem> Items { get; private set; }

        public InventoryMenu(FileStore store)
        {
            Store = store;
            Items = new List<StoreItem>();
            InitializeComponent();

            RefreshList();
        }


        private void lbInventoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedIndex = lbInventoryList.SelectedIndices[0];
        }


        private void RefreshList()
        {
            lbInventoryList.Items.Clear();
            List<StoreItem> storeItems = Store.GetStoreItems();
            this.Items = storeItems;
            IEnumerable<ListViewItem> items = storeItems.Select(si =>
            {
                ListViewItem item = new ListViewItem(si.Id.ToString());
                item.SubItems.Add(si.Name);
                item.SubItems.Add(si.Quantity.ToString());
                item.SubItems.Add(si.Price.ToString());
                return item;
            });

            lbInventoryList.Items.AddRange(items.ToArray());
        }

        private void button_AddItem_Click(object sender, EventArgs e)
        {
            var UserInputForm = new UserInput(this.Store);
            DialogResult result = UserInputForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                UserInputForm.Hide();
                this.RefreshList();
            }
        }
        
        //I want this to open the same dialog box that opens when you click "ADD"
        //then i want all the text boxes populated with the current values for the selected rows
        //then it works exactly the same as "ADD"
        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (this.selectedItem != null)
            {
                var PopulatedInputForm = new UserInput(this.Store, selectedItem);

                DialogResult result = PopulatedInputForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PopulatedInputForm.Hide();
                    this.RefreshList();
                }
            }
        }


        //this doesn't work and i'm not sure what i'm doing wrong
        private void button_DeleteItem_Click(object sender, EventArgs e)
        {
            if(this.selectedItem != null)
            {
                Store.DeleteStoreItem(this.selectedItem.Id);
                RefreshList();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
            
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            this.Store.Load();
        }        
    }
}
