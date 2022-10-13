using CKK.Persistance.Models;


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
            LoginPage loginForm = new LoginPage();
            Application.Run(loginForm);

            FileStore store = new FileStore();
            store.Load();
            if (loginForm.DialogResult == DialogResult.OK)
            {
                Application.Run(new InventoryMenu(store));
            }
        }
    }
}
