namespace EstructurasLibrary;

public class SubrayarAccion : Accion
{
    public void Ejecutar()
    {
        Console.WriteLine("Subrayando texto...");
    }

    public void Deshacer()
    {
        Console.WriteLine("Quitando subrayado...");
    }
}