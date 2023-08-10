using Microsoft.Maui.Controls;

namespace AppliedActivity5
{
    public partial class AddStudentPage : ContentPage
    {
        public AddStudentPage()
        {
            InitializeComponent();
        }

        private void OnAddStudentClicked(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var newStudent = new Student
                {
                    Name = NameEntry.Text,
                    Major = MajorEntry.Text,
                    Email = EmailEntry.Text
                };

                db.Students.Add(newStudent);
                db.SaveChanges();
            }

            Navigation.PopAsync();
        }
    }
}
