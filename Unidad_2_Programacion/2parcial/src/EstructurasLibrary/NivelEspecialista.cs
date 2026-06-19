namespace EstructurasLibrary;

public class NivelEspecialista : SoporteTecnico
{
    public override void Atender(Solicitud solicitud)
    {
        if (solicitud.Categoria == "Infraestructura" &&
            solicitud.Complejidad <= 5)
        {
            Console.WriteLine("Resuelto por NivelESpecialista 3");
        }
        else if (_siguiente != null)
        {
            _siguiente.Atender(solicitud);
        }
    }
}