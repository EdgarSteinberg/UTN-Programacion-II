namespace EstructurasLibrary;

public class NivelBasico : SoporteTecnico
{
    public override void Atender(Solicitud solicitud)
    {
        if ((solicitud.Categoria == "Cuenta" ||
             solicitud.Categoria == "Acceso") &&
             solicitud.Complejidad <= 2)
        {
            Console.WriteLine("Resuelto por NivelBasico 1");
        }
        else if (_siguiente != null)
        {
            _siguiente.Atender(solicitud);
        }
    }
}