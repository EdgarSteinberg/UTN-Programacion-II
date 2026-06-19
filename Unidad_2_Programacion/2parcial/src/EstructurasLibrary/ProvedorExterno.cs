namespace EstructurasLibrary;

public class ProveedorExterno : SoporteTecnico
{
    public override void Atender(Solicitud solicitud)
    {
        Console.WriteLine("Solicitud no resuelta");
        Console.WriteLine("Derivada derivda");
    }
}