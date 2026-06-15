namespace EstructurasLibrary;

public class Departamento : Organizacion
{
    private List<Organizacion> _organizacion;
    public List<Organizacion> Organizacion
    {
        get { return _organizacion; }
        set { _organizacion = value; }
    }
    
    public Departamento()
    {
        _organizacion = new List<Organizacion>();
    }

    public void Agregar(Organizacion organizacion)
    {
        _organizacion.Add(organizacion);
    }
    
    public override double CalcularSueldo()
    {
        double total = 0;

        foreach(Organizacion organizacion in _organizacion)
        {
            total+= organizacion.CalcularSueldo();
        }

        return total; 
    }
}