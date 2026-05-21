namespace EstructurasLibrary;

public class BancoCliente
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private string _operacion;
    public string Operacion
    {
        get { return _operacion; }
        set { _operacion = value; }
    }

    private bool _esPremium;
    public bool EsPremium
    {
        get { return _esPremium; }
        set { _esPremium = value; }
    }

    private bool _esMujer;
    public bool EsMujer
    {
        get { return _esMujer; }
        set { _esMujer = value; }
    }

    private bool _estaEmbarazada;
    public bool EstaEmbarazada
    {
        get { return _estaEmbarazada; }
        set { _estaEmbarazada = value; }
    }

    public BancoCliente(string nombre, string operacion, bool esPremium, bool esMujer, bool estaEmbarazada)
    {
        Nombre = nombre;
        Operacion = operacion;
        EsPremium = esPremium;
        EsMujer = esMujer;
        EstaEmbarazada = estaEmbarazada;
    }
}