using ejemplo_poo.Dominio;

namespace ejemplo_poo.Helpers;

public static class Printer
{
    public static void Print(string message)
    {
        Console.WriteLine(message);
    }

    public static void Print(Persona unaPersona)
    {
        Console.WriteLine(unaPersona.Saludar());
    }
}