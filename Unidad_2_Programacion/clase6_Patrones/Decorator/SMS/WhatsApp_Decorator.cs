namespace EstructurasLibrary;


public class WhatsAppDecorator : BaseDecorator
{
    public WhatsAppDecorator(INotifier notifier) : base(notifier)
    {
    }

    public override void Send(string message)
    {
        base.Send(message); // ejecuta el anterior

        Console.WriteLine($"Whapsap!: {message}");
    }
}