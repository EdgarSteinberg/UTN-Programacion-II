namespace EstructurasLibrary;

public class SocioGim
{
    private List<ActivdadesGimancio> _actividades;

    private CalcularCuotaSocioStrategy _strategy;

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string DatosPersonales { get; set; }

    public bool PaseLibre { get; set; }

    public List<ActivdadesGimancio> Actividades
    {
        get => _actividades;
        set => _actividades = value;
    }

    public SocioGim(
        string nombre,
        string apellido,
        string datosPersonales,
        bool paseLibre,
        CalcularCuotaSocioStrategy strategy)
    {
        Nombre = nombre;
        Apellido = apellido;
        DatosPersonales = datosPersonales;
        PaseLibre = paseLibre;

        _strategy = strategy;

        _actividades = new List<ActivdadesGimancio>();
    }

    public void AgregarActividad(ActivdadesGimancio actividad)
    {
        _actividades.Add(actividad);
    }

    public double CalcularCuota()
    {
        return _strategy.CalcularCuotaSocio(this);
    }
    public string MostrarActividades()
    {
        string resultado = "";

        foreach (ActivdadesGimancio actividad in Actividades)
        {
            resultado += actividad.NombreActividad + " ";
        }

        return resultado;
    }

}