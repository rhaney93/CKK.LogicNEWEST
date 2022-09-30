using System;
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

namespace CKK.UI
{
    public partial class Form2 : Form
    {
        private IStore Store;

        public ObservableCollection<StoreItem> Items { get; private set; }

        public Form2(Store store)
        {
            Store = store;
            InitializeComponent();
            Items = new ObservableCollection<StoreItem>();
            RefreshList();
        }

        private void RefreshList()
        {
            Items.Clear();
            foreach (StoreItem si in new ObservableCollection<StoreItem>(Store.GetStoreItems()))
                Items.Add(si);
        }

        private void button_AddItem_Click(object sender, EventArgs e)
        {
            //How does the user access this method by clicking the button?
            //Store.AddStoreItem();
        }

        private void button_DeleteItem_Click(object sender, EventArgs e)
        {
            
            //Store.RemoveStoreItem();
        }
    }
}
