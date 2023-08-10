using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace AppliedActivity5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (var db = new AppDbContext())
            {
                StudentsListView.ItemsSource = db.Students.ToList();
            }
        }
    }
}