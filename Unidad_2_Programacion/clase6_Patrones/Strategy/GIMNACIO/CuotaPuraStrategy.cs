namespace EstructurasLibrary;

public class CuotaPuraGimnacioStrategy : CalcularCuotaSocioStrategy
{
    public override double CalcularCuotaSocio(SocioGim socio)
    {
        double total = 0;

        foreach (ActivdadesGimancio actividad in socio.Actividades)
        {
            total += actividad.PrecioMensualActividad;
        }

        return total;
    }
}