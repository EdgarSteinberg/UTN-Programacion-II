namespace EstructurasLibrary;

public class PromocionGimnacio
{
    private List<ActivdadesGimancio> _actividades;

    public List<ActivdadesGimancio> Actividades
    {
        get => _actividades;
        set => _actividades = value;
    }

    public string Nombre { get; set; }

    public double DescuentoPromo { get; set; }


    public PromocionGimnacio(string nombre, double descuentoPromo)
    {
        Nombre = nombre;
        DescuentoPromo = descuentoPromo;

        _actividades = new List<ActivdadesGimancio>();
    }

    public void AgregarActividad(ActivdadesGimancio actividad)
    {
        _actividades.Add(actividad);
    }

    public bool AplicaPromocion(SocioGim socio)
    {
        int cantidad = 0;

        foreach (var actividadSocio in socio.Actividades)
        {
            if (_actividades.Contains(actividadSocio))
            {
                cantidad++;
            }
        }

        return cantidad >= 2;
    }

    public double AplicarDescuento(SocioGim socio, double cuota)
    {
        if (AplicaPromocion(socio))
        {
            return cuota - (cuota * DescuentoPromo);
        }

        return cuota;
    }
}