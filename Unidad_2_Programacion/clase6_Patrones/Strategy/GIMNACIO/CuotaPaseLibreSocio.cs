namespace EstructurasLibrary;

public class CuotaPaseLibreSocio : CalcularCuotaSocioStrategy
{
    private const double PRECIO_PASE_LIBRE = 25000;

    public override double CalcularCuotaSocio(SocioGim socio)
    {
        return PRECIO_PASE_LIBRE;
    }
}