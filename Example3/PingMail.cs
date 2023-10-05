using Example4;

namespace Example3
{
    public class PingMail : ISendEmailMessage
    {
        public void SendEmail(string mail)
        {
            Console.WriteLine(mail);
        }
    }
}