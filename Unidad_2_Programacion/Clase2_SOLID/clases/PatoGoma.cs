namespace EstructurasLibrary;


public class PatoGoma : INadador, ICuack
{
    public void Cuack()
    {
        Console.WriteLine("El pato de goma hace cuack");
    }

    public void Nadar()
    {
        Console.WriteLine("El pato de goma está nadando");
    }
}