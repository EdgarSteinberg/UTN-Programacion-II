namespace EstructurasLibrary;

public class UAP : BaseSanitaria
{
    public double TiempoMedioAsistencia { get; set; }

    public UAP( string nombre,string direccion,double tiempoMedioAsistencia)
        : base(nombre, direccion)
    {
        TiempoMedioAsistencia = tiempoMedioAsistencia;
    }

    public override int ObtenerCantidadAmbulancias()
    {
        return 0;
    }

    public override double ObtenerTiempoMedioAsistencia()
    {
        return TiempoMedioAsistencia;
    }
}