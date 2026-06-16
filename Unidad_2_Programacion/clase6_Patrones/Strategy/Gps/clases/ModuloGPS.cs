namespace EstructurasLibrary;

public class ModuloGPS
{
    private string _tecnologia;

    public string Tecnologia
    {
        get { return _tecnologia; }
        set { _tecnologia = value; }
    }

    public ModuloGPS(string tecnologia)
    {
        _tecnologia = tecnologia;
    }

    public void ObtenerSatelites()
    {
        Console.WriteLine("Buscando satélites...");
    }

    public (double lat, double lon) ObtenerPosicionActual()
    {
        Console.WriteLine("Calculando posición GPS...");
        return (-34.60, -58.38);
    }

    public void TransmitirPosicionActual()
    {
        var pos = ObtenerPosicionActual();
        Console.WriteLine($"Transmitiendo: {pos.lat}, {pos.lon}");
    }
}