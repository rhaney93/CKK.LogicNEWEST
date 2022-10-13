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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            this.textBox_Username.Text = "username";
            this.textBox_Password.Text = "password";
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
