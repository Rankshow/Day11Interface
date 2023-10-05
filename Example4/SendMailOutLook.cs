namespace Example4
{
    public class SendMailOutLook : ISendEmailMessage
    {
        public void SendEmail(string mail) 
        {
            Console.WriteLine("We have seen your messages");
        }
    }
}