using System;
using System.Windows.Forms;
using CKK.Logic.Models;

namespace CKK.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 loginForm = new Form1();
            Application.Run(loginForm);

            Store store = new Store();
            if (loginForm.DialogResult == DialogResult.OK)
            {
                Application.Run(new Form2(store));
            }
        }
    }
}
