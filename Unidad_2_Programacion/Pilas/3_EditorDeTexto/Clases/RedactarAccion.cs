namespace EstructurasLibrary;


public class RedactarAccion : Accion
{
    public void Ejecutar()
    {
        Console.WriteLine("Escribiendo texto...");
    }

    public void Deshacer()
    {
        Console.WriteLine("Borrando texto...");
    }
}