namespace TemplateMethod;

public class ExchangeMailParser : MailParser
{
    public override void AuthenticateToServer()
    {
        Console.WriteLine("Connection to Exchange");
    }
}