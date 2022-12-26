using System.Data;
using CKK.DB.Interfaces;
using CKK.Logic.Models;

namespace CKK.UI
{
    public partial class InventoryMenu : Form
    {
        private IProductRepository Store;

        private int selectedIndex = -1;
        private Product? selectedItem
        {
            get { 
                if (selectedIndex >= 0)
                {
                    return this.Items[selectedIndex];
                }

                return null;
            }
        }
        

        public List<Product> Items { get; private set; }

        public InventoryMenu(IProductRepository store)
        {
            Store = store;
            Items = new List<Product>();
            InitializeComponent();

            RefreshList();
        }


        private void lbInventoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedIndex = lbInventoryList.SelectedIndices[0];
        }



        private void RefreshList()
        {
            
            List<Product> storeItems = Store.GetAll();
            this.Items = storeItems;
         
            this.ReloadList();
        }

        private void ReloadList()
        {
            lbInventoryList.Items.Clear();

            IEnumerable<ListViewItem> items = this.Items.Select(si =>
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

        private void button_DeleteItem_Click(object sender, EventArgs e)
        {
            if(this.selectedItem != null)
            {
                Store.Delete(this.selectedItem.Id);
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

        private void button_Search_Click(object sender, EventArgs e)
        {
            var searchString = this.textBox_Search.Text;
            this.Items = this.Store.GetByName(searchString);
            this.ReloadList();
        }
    }
}
