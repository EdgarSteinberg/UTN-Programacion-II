namespace EstructurasLibrary;

public class Persona
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private bool _esMayor;
    public bool EsMayor
    {
        get { return _esMayor; }
        set { _esMayor = value; }
    }

    private bool _esExcelencia;

    public bool EsExcelencia
    {
        get { return _esExcelencia; }
        set { _esExcelencia = value; }
    }

    public Persona(string nombre, bool esMayor, bool esExelencia)
    {
        Nombre = nombre;
        EsMayor = esMayor;
        EsExcelencia = esExelencia;
    }
}