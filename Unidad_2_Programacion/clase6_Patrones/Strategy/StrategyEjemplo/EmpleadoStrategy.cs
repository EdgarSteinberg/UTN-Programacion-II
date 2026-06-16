namespace EstructurasLibrary;

public class EmpladoStrategy
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private int _sueldo;
    public int Sueldo
    {
        get { return _sueldo; }
        set { _sueldo = value; }
    }

    private int _horasTrabajadas;
    public int HorasTrabajadas
    {
        get { return _horasTrabajadas; }
        set { _horasTrabajadas = value; }
    }

    private int _ventas;
    public int Ventas
    {
        get { return _ventas; }
        set { _ventas = value; }
    }


    private CalcularSueldosStrategy _strategy;


    public EmpladoStrategy(CalcularSueldosStrategy strategia, string nombre, int horasTrabajadas, int ventas)
    {
        _strategy = strategia;
        Nombre = nombre;
        HorasTrabajadas = horasTrabajadas;
        Ventas = ventas;
    }

    public int CalcularSueldo()
    {
        return _strategy.CalcularSueldoS(this);
    }
}