using System.Text;
namespace Example9
{
    public class Student
    {
        public Student()
        {
            StudentId = Guid.NewGuid();
        }
        public Guid StudentId { get; private set; }
        public string? FullName { get; set; }
        public int Age { set; get; }
        public string? StateOfOrigin { set; get; }
        public string? Email { set; get; }
        public string? Gender { set; get; }
    }
}