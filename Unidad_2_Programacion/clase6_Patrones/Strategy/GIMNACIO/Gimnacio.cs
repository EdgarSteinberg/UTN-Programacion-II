namespace EstructurasLibrary;

public class GimnacioIndioSolari
{
    private List<ActivdadesGimancio> _actividadesGimnacio;
    private List<SocioGim> _sociosGimnacio;
    private List<PromocionGimnacio> _promocionesGimnacio;

    public List<ActivdadesGimancio> ActividadesGimnacio
    {
        get => _actividadesGimnacio;
        set => _actividadesGimnacio = value;
    }

    public List<SocioGim> SociosGimnacio
    {
        get => _sociosGimnacio;
        set => _sociosGimnacio = value;
    }

    public List<PromocionGimnacio> PromocionesGimnacio
    {
        get => _promocionesGimnacio;
        set => _promocionesGimnacio = value;
    }

    public string NombreGimnacio { get; set; }

    public GimnacioIndioSolari(string nombreGimnacio)
    {
        NombreGimnacio = nombreGimnacio;

        _actividadesGimnacio = new List<ActivdadesGimancio>();
        _sociosGimnacio = new List<SocioGim>();
        _promocionesGimnacio = new List<PromocionGimnacio>();
    }

    public void AgregarActividad(ActivdadesGimancio actividad)
    {
        _actividadesGimnacio.Add(actividad);
    }

    public void AgregarSocio(SocioGim socio)
    {
        _sociosGimnacio.Add(socio);
    }

    public void AgregarPromocion(PromocionGimnacio promocion)
    {
        _promocionesGimnacio.Add(promocion);
    }

      public void EliminarPromocion(PromocionGimnacio promocion)
    {
        _promocionesGimnacio.Remove(promocion);
    }
}