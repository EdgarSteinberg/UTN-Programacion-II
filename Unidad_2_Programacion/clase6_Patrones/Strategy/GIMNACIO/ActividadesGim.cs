namespace EstructurasLibrary;

public class ActivdadesGimancio
{
    public string NombreActividad { get; set; }

    public string DescripcionActividad { get; set; }

    public double PrecioMensualActividad { get; set; }

    public string InstructorActividad { get; set; }

    public int DiaActividad { get; set; }

    public int HorarioActividad { get; set; }

    public ActivdadesGimancio(
        string nombreActividad,
        string descripcionActividad,
        double precioMensualActividad,
        string instructorActividad,
        int diaActividad,
        int horarioActividad)
    {
        NombreActividad = nombreActividad;
        DescripcionActividad = descripcionActividad;
        PrecioMensualActividad = precioMensualActividad;
        InstructorActividad = instructorActividad;
        DiaActividad = diaActividad;
        HorarioActividad = horarioActividad;
    }
}