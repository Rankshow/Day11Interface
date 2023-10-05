namespace Example4
{
    public class SendYahooMail : ISendEmailMessage
    {
        public void SendEmail(string mail)
        {
            Console.WriteLine($"{mail}");
        }
    }
}