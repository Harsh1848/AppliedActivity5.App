using Microsoft.EntityFrameworkCore;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace AppliedActivity5
{
    public partial class App : Application
    {
        public static string DatabasePath;

        public App()
        {
            InitializeComponent();
            DatabasePath = Path.Combine(FileSystem.AppDataDirectory, "mydb.db3");
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            using (var db = new AppDbContext())
            {
                db.Database.Migrate();
            }
        }
    }
}