namespace EstructurasLibrary;

public class ConversorUTM : IConversorCordenadas
{
    public (double X, double Y) Convertir(double lat, double lon)
    {
        // conversión simplificada para examen
        double x = lat * 1000;
        double y = lon * 1000;

        return (x, y);
    }
}