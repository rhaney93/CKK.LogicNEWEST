namespace CKK.UI
{
    partial class Form2
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
            this.lbInventoryList = new System.Windows.Forms.ListBox();
            this.button_AddItem = new System.Windows.Forms.Button();
            this.button_DeleteItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Search.Location = new System.Drawing.Point(175, 36);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(842, 53);
            this.textBox_Search.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.Location = new System.Drawing.Point(1027, 36);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(194, 54);
            this.button_Search.TabIndex = 6;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            // 
            // lbInventoryList
            // 
            this.lbInventoryList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInventoryList.FormattingEnabled = true;
            this.lbInventoryList.ItemHeight = 41;
            this.lbInventoryList.Location = new System.Drawing.Point(29, 202);
            this.lbInventoryList.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.lbInventoryList.Name = "lbInventoryList";
            this.lbInventoryList.ScrollAlwaysVisible = true;
            this.lbInventoryList.Size = new System.Drawing.Size(1187, 1193);
            this.lbInventoryList.TabIndex = 7;
            // 
            // button_AddItem
            // 
            this.button_AddItem.Location = new System.Drawing.Point(175, 116);
            this.button_AddItem.Name = "button_AddItem";
            this.button_AddItem.Size = new System.Drawing.Size(401, 58);
            this.button_AddItem.TabIndex = 8;
            this.button_AddItem.Text = "Add Item";
            this.button_AddItem.UseVisualStyleBackColor = true;
            this.button_AddItem.Click += new System.EventHandler(this.button_AddItem_Click);
            // 
            // button_DeleteItem
            // 
            this.button_DeleteItem.Location = new System.Drawing.Point(616, 116);
            this.button_DeleteItem.Name = "button_DeleteItem";
            this.button_DeleteItem.Size = new System.Drawing.Size(401, 58);
            this.button_DeleteItem.TabIndex = 9;
            this.button_DeleteItem.Text = "Delete Item";
            this.button_DeleteItem.UseVisualStyleBackColor = true;
            this.button_DeleteItem.Click += new System.EventHandler(this.button_DeleteItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 1446);
            this.Controls.Add(this.button_DeleteItem);
            this.Controls.Add(this.button_AddItem);
            this.Controls.Add(this.lbInventoryList);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Search);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Search;
        private ListBox lbInventoryList;
        private Button button_AddItem;
        private Button button_DeleteItem;
    }
}