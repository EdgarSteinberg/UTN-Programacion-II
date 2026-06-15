namespace EstructurasLibrary;

//1. Component
public interface INotifier
{
    void Send(string message);
}


/* public abstract class INotifier
{
    public string Usuario { get; set; }

    public abstract void Send(string message);
} */