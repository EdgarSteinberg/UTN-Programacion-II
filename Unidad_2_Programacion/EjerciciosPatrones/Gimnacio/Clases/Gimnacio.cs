namespace EstructurasLibrary;


public class Gimnasio
{
    private List<Actividad> _actividades;
    public List<Actividad> Actividades
    {
        get { return _actividades; }
        set { _actividades = value; }
    }

    private List<Socio> _socios;
    public List<Socio> Socios
    {
        get { return _socios; }
        set { _socios = value; }
    }

    private List<Promocion> _promociones;
    public List<Promocion> Promociones
    {
        get { return _promociones; }
        set { _promociones = value; }
    }


    private Promocion _promocionVigente;

    public Promocion PromocionVigente
    {
        get { return _promocionVigente; }
        set { _promocionVigente = value; }
    }

    public Gimnasio()
    {
        _actividades = new List<Actividad>();
        _socios = new List<Socio>();
        _promociones = new List<Promocion>();
        _promocionVigente = null;
    }
    

    public void AgregarActividad(Actividad actividad)
    {
        _actividades.Add(actividad);
    }

    public void AgregarSocio(Socio socio)
    {
        _socios.Add(socio);
    }

    public void AgregarPromocion(Promocion promo)
    {
        _promociones.Add(promo);
    }
}

