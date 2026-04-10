namespace trenes_profesor_code.Clases;

public class Formacion
{
    private List<Locomotora> _locomotoras;

    public List<Locomotora> Locomotoras
    {
        get { return _locomotoras; }
        set { _locomotoras = value; }
    }

    private List<Vagon> _vagones;

    public List<Vagon> Vagones
    {
        get { return _vagones; }
        set { _vagones = value; }
    }
    private bool _estaEnMovimiento;

    public bool EstaEnMovimiento
    {
        get { return _estaEnMovimiento; }
        set { _estaEnMovimiento = value; }
    }

    public Formacion(Locomotora locomotora)
    {
        _locomotoras = new List<Locomotora>();
        _locomotoras.Add(locomotora);
        _estaEnMovimiento = false;

        _vagones = new List<Vagon>();
        _estaEnMovimiento = false;
    }
}