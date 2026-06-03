namespace EstructurasLibrary;

public class Hospital : BaseSanitaria
{
    public int CantidadAmbulancias { get; set; }

    public double TiempoMedioAsistencia { get; set; }

    public Hospital(string nombre, string direccion,int cantidadAmbulancias, double tiempoMedioAsistencia)
        : base(nombre, direccion)
    {
        CantidadAmbulancias = cantidadAmbulancias;
        TiempoMedioAsistencia = tiempoMedioAsistencia;
    }

    public override int ObtenerCantidadAmbulancias()
    {
        return CantidadAmbulancias;
    }

    public override double ObtenerTiempoMedioAsistencia()
    {
        return TiempoMedioAsistencia;
    }
}