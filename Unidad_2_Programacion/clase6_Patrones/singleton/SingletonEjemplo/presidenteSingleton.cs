namespace EstructurasLibrary;

public class PresidenteSingleton
{

    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private string _apellido;
    public string Apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }

    private static PresidenteSingleton _instancia;

    public static PresidenteSingleton EleccionesNuevas(string nombre, string apellido)
    {
        if (_instancia == null)
        {
            _instancia = new PresidenteSingleton();
        }

        _instancia.Nombre = nombre;
        _instancia.Apellido = apellido;

        return _instancia;
    }

    private PresidenteSingleton()
    {
        Nombre = "";
        Apellido = "";
    }
}