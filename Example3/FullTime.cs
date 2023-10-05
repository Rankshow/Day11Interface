namespace Example3
{
    public class FullTime : IEmployer
    {
        public void Project(string[] hybrid)
        {
            foreach(string work in hybrid)
            {
                Console.WriteLine(work);
            }
        }
        public void Manager(int[] collate)
        {
            foreach(int jobId in collate)
            {
                Console.WriteLine(jobId);
            }
        }
    }
}