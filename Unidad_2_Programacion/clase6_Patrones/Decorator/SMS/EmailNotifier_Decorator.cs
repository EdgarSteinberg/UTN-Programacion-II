namespace EstructurasLibrary;

//2. Concrete Component
public class EmailNotifierDecorator : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($" Email : {message}");
    }
}