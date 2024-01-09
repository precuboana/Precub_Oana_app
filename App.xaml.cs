using Precub_Oana_app.Data;
using System.IO;
using System;

namespace Precub_Oana_app
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;
        public static bool IsUserLoggedIn { get; set; }

        // Proprietatea statică Database pentru acces global
        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "YourDatabaseName.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new NavigationPage(new MainPage()); // Pagina principală a aplicației
            }
        }
    }
}
