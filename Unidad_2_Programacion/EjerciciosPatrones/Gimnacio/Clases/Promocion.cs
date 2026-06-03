namespace EstructurasLibrary;

public class Promocion
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private decimal _porcentajeDescuento;
    public decimal PorcentajeDescuento
    {
        get { return _porcentajeDescuento; }
        set { _porcentajeDescuento = value; }
    }

    private List<Actividad> _actividades;
    public List<Actividad> Actividades
    {
        get { return _actividades; }
        set { _actividades = value; }
    }

    public Promocion(string nombre, decimal porcentajeDescuento)
    {
        Nombre = nombre;
        PorcentajeDescuento = porcentajeDescuento;
        _actividades = new List<Actividad>();
    }

    public bool Aplica(Socio s)
    {
        int contador = 0;

        foreach (Actividad actSocio in s.Actividades)
        {
            foreach (Actividad actPromo in _actividades)
            {
                if (actSocio.Nombre == actPromo.Nombre)
                {
                    contador++;
                }
            }
        }

        return contador >= 2;
    }

    public decimal CalcularDescuento(decimal total)
    {
        return total * PorcentajeDescuento / 100;
    }
}