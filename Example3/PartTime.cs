namespace Example3
{
    public class PartTime : IEmployer
    {
        public void Project(string[] hybrid)
        {
            foreach(string development in hybrid)
            {
                Console.WriteLine(development);
            }
        }
        public void Manager(int[] collate)
        {
            foreach(int clientId in collate)
            {
                Console.WriteLine(clientId);
            }
        }
    }
}