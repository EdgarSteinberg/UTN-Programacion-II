namespace EstructurasLibrary;


public class Aplicacion
{
    private List<Destino> _destinos;
    public List<Destino> Destinos
    {
        get { return _destinos; }
        set { _destinos = value; }
    }

    private DateTime _horaLocal;
    public DateTime HoraLocal
    {
        get { return _horaLocal; }
        set { _horaLocal = value; }
    }

    public Aplicacion()
    {
        _destinos = new List<Destino>();
    
    }

    public void EstablecerFecha(DateTime hora)
    {
        HoraLocal = hora;
    }

    public void AgregarDestino(Destino d)
    {
        _destinos.Add(d);
    }

    public void EliminarDestino(Destino d)
    {
        _destinos.Remove(d);
    }

    public void MostrarHoras()
    {
        foreach (Destino destino in _destinos)
        {
            var horaDestino = destino.CalcularHora(HoraLocal);

            Console.WriteLine(
                $"Destino: {destino.Nombre} -> {horaDestino}"
            );
        }
    }
}