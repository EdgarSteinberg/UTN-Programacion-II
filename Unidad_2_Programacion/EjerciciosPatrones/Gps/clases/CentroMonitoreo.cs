namespace EstructurasLibrary;

public class CentroMonitoreo
{
    private List<ModuloGPS> _modulos;
    private IConversorCordenadas _conversor; // Stratergy

    public CentroMonitoreo(IConversorCordenadas conversor)
    {
        _modulos = new List<ModuloGPS>();
        _conversor = conversor;
    }

    public void AgregarModulo(ModuloGPS modulo)
    {
        _modulos.Add(modulo);
    }

    public void SeguimientoVehiculo()
    {
        foreach (var modulo in _modulos)
        {
            var gps = modulo.ObtenerPosicionActual();

            var utm = _conversor.Convertir(gps.lat, gps.lon);

            //Console.WriteLine($"Modulo {modulo.Tecnologia} -> UTM X:{utm.X} Y:{utm.Y}");
            Console.WriteLine($"[{modulo.Tecnologia}] GPS({gps.lat},{gps.lon}) -> UTM({utm.X},{utm.Y})");
        }
    }
}