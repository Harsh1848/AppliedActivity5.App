// Student.cs

namespace AppliedActivity5
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Major { get; set; }
        public string Email { get; set; }
    }

}
