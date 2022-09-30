using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKK.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if(textBox_Username.Text == "username" && textBox_Password.Text == "password")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }

            else
            {
                MessageBox.Show("Username is username, Password is password");
                textBox_Username.Clear();
                textBox_Password.Clear();
                textBox_Username.Focus();
                this.DialogResult = DialogResult.Retry;
            }
        }
    }
}
