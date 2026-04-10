namespace trenes_profesor_code.Clases;

public class Deposito
{
    private List<Locomotora> _locomotoras;
    private List<Formacion> _formaciones;

    public Deposito()
    {
        _locomotoras = new List<Locomotora>();
        _formaciones = new List<Formacion>();
    }

    public List<Locomotora> Locomotoras
    {
        get { return _locomotoras; }
        set { _locomotoras = value; }
    }

    public List<Formacion> Formaciones
    {
        get { return _formaciones; }
        set { _formaciones = value; }
    }

    public void AgregarLocomotoraEnFormacion(Locomotora plocomotora, Formacion pformacion)
    {
        if (!pformacion.EstaEnMovimiento)
        {
            pformacion.Locomotoras.Add(plocomotora);
        }
    }
}