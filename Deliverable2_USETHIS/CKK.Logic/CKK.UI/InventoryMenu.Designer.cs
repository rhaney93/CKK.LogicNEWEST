namespace CKK.UI
{
    partial class InventoryMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.lbInventoryList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.button_AddItem = new System.Windows.Forms.Button();
            this.button_DeleteItem = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.Location = new System.Drawing.Point(29, 12);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(871, 47);
            this.textBox_Search.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Search.Location = new System.Drawing.Point(960, 12);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(251, 47);
            this.button_Search.TabIndex = 10;
            this.button_Search.Text = "Search";
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // lbInventoryList
            // 
            this.lbInventoryList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInventoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lbInventoryList.FullRowSelect = true;
            this.lbInventoryList.GridLines = true;
            this.lbInventoryList.Location = new System.Drawing.Point(29, 170);
            this.lbInventoryList.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.lbInventoryList.Name = "lbInventoryList";
            this.lbInventoryList.Size = new System.Drawing.Size(1187, 1184);
            this.lbInventoryList.TabIndex = 7;
            this.lbInventoryList.UseCompatibleStateImageBehavior = false;
            this.lbInventoryList.View = System.Windows.Forms.View.Details;
            this.lbInventoryList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lbInventoryList_ColumnClick);
            this.lbInventoryList.SelectedIndexChanged += new System.EventHandler(this.lbInventoryList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 63;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 903;
            // 
            // button_AddItem
            // 
            this.button_AddItem.Location = new System.Drawing.Point(27, 84);
            this.button_AddItem.Name = "button_AddItem";
            this.button_AddItem.Size = new System.Drawing.Size(251, 58);
            this.button_AddItem.TabIndex = 8;
            this.button_AddItem.Text = "Add Item";
            this.button_AddItem.UseVisualStyleBackColor = true;
            this.button_AddItem.Click += new System.EventHandler(this.button_AddItem_Click);
            // 
            // button_DeleteItem
            // 
            this.button_DeleteItem.Location = new System.Drawing.Point(960, 84);
            this.button_DeleteItem.Name = "button_DeleteItem";
            this.button_DeleteItem.Size = new System.Drawing.Size(251, 58);
            this.button_DeleteItem.TabIndex = 9;
            this.button_DeleteItem.Text = "Delete Item";
            this.button_DeleteItem.UseVisualStyleBackColor = true;
            this.button_DeleteItem.Click += new System.EventHandler(this.button_DeleteItem_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(649, 84);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(251, 58);
            this.button_Refresh.TabIndex = 13;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(29, 1365);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(249, 58);
            this.button_Load.TabIndex = 14;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(338, 84);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(251, 58);
            this.button_Edit.TabIndex = 15;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // InventoryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 1946);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_DeleteItem);
            this.Controls.Add(this.button_AddItem);
            this.Controls.Add(this.lbInventoryList);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Search);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "InventoryMenu";
            this.Text = "Inventory ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Search;
        private ListView lbInventoryList;
        private Button button_AddItem;
        private Button button_DeleteItem;
        private Button button_Refresh;
        private Button button_Load;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button_Edit;
    }
}