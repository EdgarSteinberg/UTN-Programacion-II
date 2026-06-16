namespace EstructurasLibrary;


public interface IConversorCordenadas
{
    (double X, double Y) Convertir(double lat, double lon);
}