namespace EstructurasLibrary;


public class Actividad
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private string _descripcion;
    public string Descripcion
    {
        get { return _descripcion; }
        set { _descripcion = value; }
    }
    
   private decimal _precioMensual;
public decimal PrecioMensual
{
    get { return _precioMensual; }
    set { _precioMensual = value; }
}
    
    private string _instructor;
    public string Instructor
    {
        get { return _instructor; }
        set { _instructor = value; }
    }
    
    private string _dias;
    public string Dias
    {
        get { return _dias; }
        set { _dias = value; }
    }
    
    private string _horarios;
    public string Horarios
    {
        get { return _horarios; }
        set { _horarios = value; }
    }
    

    public Actividad(string nombre, string descripcion, decimal precioMensual, string instructor, string dias, string horarios)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        PrecioMensual = precioMensual;
        Instructor = instructor;
        Dias = dias;
        Horarios = horarios;
    }
}