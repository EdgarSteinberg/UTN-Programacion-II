namespace EstructurasLibrary;

public class Socio
{
    private List<Actividad> _actividades;
    public List<Actividad> Actividades
    {
        get { return _actividades; }
        set { _actividades = value; }
    }

    private bool _tienePaseLibre;

    public bool TienePaseLibre
    {
        get { return _tienePaseLibre; }
        set { _tienePaseLibre = value; }
    }

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

    private int _dni;
    public int Dni
    {
        get { return _dni; }
        set { _dni = value; }
    }

    private string _direccion;
    public string Direccion
    {
        get { return _direccion; }
        set { _direccion = value; }
    }

    private string _email;
    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    private int _telefono;
    public int Telefono
    {
        get { return _telefono; }
        set { _telefono = value; }
    }

    private ICalcularCuota _estrategia;

    public void SetEstrategia(ICalcularCuota estrategia)
    {
        _estrategia = estrategia;
    }

    public decimal CalcularCuota(Gimnasio g)
    {
        if (_estrategia == null)
            throw new Exception("Falta estrategia");

        return _estrategia.Costo(this, g);
    }

    public void AgregarActividad(Actividad actividad)
    {
        _actividades.Add(actividad);
    }
    public Socio(string nombre, string apellido, int dni, string direccion, string email, int telefono)
    {
        Nombre = nombre;
        Apellido = apellido;
        Dni = dni;
        Direccion = direccion;
        Email = email;
        Telefono = telefono;
        _actividades = new List<Actividad>();
    }

    
}