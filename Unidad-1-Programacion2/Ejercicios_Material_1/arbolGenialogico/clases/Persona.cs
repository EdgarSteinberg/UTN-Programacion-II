namespace Ejercicio.clases;

public class Persona
{
    private string _nombre = "";
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private string _apellido = "";
    public string Apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }

    public Persona(string n, string a, int anio)
    {
        Nombre = n;
        Apellido = a;
        Anio_nacimiento = anio;
    }
    private List<Persona> _hijos = new List<Persona>();

    public List<Persona> Hijos
    {
        get { return _hijos; }
        set { _hijos = value; }
    }

    private int anio_nacimiento = 0;
    public int Anio_nacimiento
    {
        get { return anio_nacimiento; }
        set { anio_nacimiento = value; }
    }

    public string Id()
    {
        return Anio_nacimiento.ToString().Substring(2)
            + Nombre[0]
            + Apellido[0];
    }

    public void AgregarHijo(Persona hijo)
    {
        Hijos.Add(hijo);
    }
}