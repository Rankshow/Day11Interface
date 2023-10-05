namespace Example2
{
    public class Assignment : IStudents
    {
        public void Study(string[] student)
        {
           foreach(string std in student)
           {
                Console.WriteLine(std);
           }
        }
    }
}