namespace EstructurasLibrary;

public class Empleado : Organizacion
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    
    private double _sueldo;
    public double Sueldo
    {
        get { return _sueldo; }
        set { _sueldo = value; }
    }
    
    public override double CalcularSueldo()
    {
        return Sueldo;
    }

    public Empleado(string nombre , double sueldo)
    {
        Nombre = nombre;
        Sueldo = sueldo;
    }
}