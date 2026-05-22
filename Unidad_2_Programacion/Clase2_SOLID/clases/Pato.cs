namespace EstructurasLibrary;

public class Pato : IVolador, INadador, ICuack
{
    public void Cuack()
    {
        Console.WriteLine("El pato hace cuack.");

    }

    public void Nadar()
    {
        Console.WriteLine("El pato esta nadando.");
    }

    public void Volar()
    {
        Console.WriteLine("El pato esta volando.");
    }
}