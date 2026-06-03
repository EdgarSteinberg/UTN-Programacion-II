namespace EstructurasLibrary;


public class Mascota
{
    private int _nivelContenta;

    public int NivelContenta
    {
        get { return _nivelContenta; }
        set { _nivelContenta = value; }
    }

    private IEstadoMascota _estado;
    public IEstadoMascota Estado
    {
        get { return _estado; }
        set { _estado = value; }
    }

    public Mascota(int nivelContenta, IEstadoMascota estado)
    {
        NivelContenta = nivelContenta;
        Estado = estado;
    }

    public void Comer()
    {
        Estado.Comer(this);
    }

    public void Jugar()
    {
        Estado.Jugar(this);
    }

    public bool PuedeJugar()
    {
        return Estado.PuedeJugar();
    }
}