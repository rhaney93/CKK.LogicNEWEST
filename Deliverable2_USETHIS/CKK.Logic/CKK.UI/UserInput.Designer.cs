namespace CKK.UI
{
    partial class UserInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_NameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_QuantityField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Price_Field = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(633, 762);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(188, 58);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_NameField
            // 
            this.textBox_NameField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_NameField.Location = new System.Drawing.Point(112, 219);
            this.textBox_NameField.Name = "textBox_NameField";
            this.textBox_NameField.PlaceholderText = "Enter item name";
            this.textBox_NameField.Size = new System.Drawing.Size(709, 61);
            this.textBox_NameField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity:";
            // 
            // textBox_QuantityField
            // 
            this.textBox_QuantityField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_QuantityField.Location = new System.Drawing.Point(112, 406);
            this.textBox_QuantityField.Name = "textBox_QuantityField";
            this.textBox_QuantityField.PlaceholderText = "Enter a whole number";
            this.textBox_QuantityField.Size = new System.Drawing.Size(709, 61);
            this.textBox_QuantityField.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(112, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price:";
            // 
            // textBox_Price_Field
            // 
            this.textBox_Price_Field.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Price_Field.Location = new System.Drawing.Point(112, 610);
            this.textBox_Price_Field.Name = "textBox_Price_Field";
            this.textBox_Price_Field.PlaceholderText = "Enter dollars and cents- 1.00, 2.50, etc";
            this.textBox_Price_Field.Size = new System.Drawing.Size(709, 61);
            this.textBox_Price_Field.TabIndex = 2;
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 901);
            this.Controls.Add(this.textBox_Price_Field);
            this.Controls.Add(this.textBox_QuantityField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_NameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label1);
            this.Name = "UserInput";
            this.Text = "UserInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button_Save;
        private TextBox textBox_NameField;
        private Label label2;
        private TextBox textBox_QuantityField;
        private Label label3;
        private TextBox textBox_Price_Field;
    }
}