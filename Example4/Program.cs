using Example4;

SendYahooMail send = new SendYahooMail();

MessagesSent(send, "We see the future is revolving");

static void MessagesSent(ISendEmailMessage sender, string mail)
{
    sender.SendEmail(mail);
}