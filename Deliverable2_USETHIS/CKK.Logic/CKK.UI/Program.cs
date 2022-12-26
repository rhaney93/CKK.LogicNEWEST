using CKK.DB.UOW;

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

            // Create a new connection factory and UnitOfWork to connect to the DB
            var factory = new DatabaseConnectionFactory();
            var worker = new UnitOfWork(factory);

            if (loginForm.DialogResult == DialogResult.OK)
            {
                // Ensure the proper repository is supplied to the UI!
                Application.Run(new InventoryMenu(worker.Products));
            }
        }
    }
}
