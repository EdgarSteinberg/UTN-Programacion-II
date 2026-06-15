namespace EstructurasLibrary;

public class SMSDecorator : BaseDecorator
{
    public SMSDecorator(INotifier notifier): base(notifier)
    {
    }
    //no se porque no se hereda el metodo
    public override void Send(string message)
    {
        base.Send(message); // ejecuta el anterior

        Console.WriteLine($"SMS: {message}");
    }
}