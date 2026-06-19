namespace EstructurasLibrary;
public class NivelTecnico : SoporteTecnico
{
    public override void Atender(Solicitud solicitud)
    {
        if (solicitud.Categoria == "Software" &&
            solicitud.Complejidad <= 4)
        {
            Console.WriteLine("Resuelto por NivelTecnico 2");
        }
        else if (_siguiente != null)
        {
            _siguiente.Atender(solicitud);
        }
    }
}