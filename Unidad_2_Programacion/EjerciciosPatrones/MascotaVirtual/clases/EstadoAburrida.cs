namespace EstructurasLibrary;

 
public class EstadoAburrida : IEstadoMascota
{
    private int _minutos;

    public int Minutos
    {
        get { return _minutos; }
        set { _minutos = value; }
    }

    public EstadoAburrida(int minutos)
    {
        Minutos = minutos;
    }

    public void Comer(Mascota mascota)
    {
        if (Minutos > 80)
        {
            mascota.Estado = new EstadoContenta();
            Console.WriteLine("La mascota estaba aburrida y ahora está contenta.");
        }
        else
        {
            Console.WriteLine("La mascota sigue aburrida.");
        }
    }

    public void Jugar(Mascota mascota)
    {
        mascota.Estado = new EstadoContenta();
        Console.WriteLine("La mascota estaba aburrida y ahora está contenta.");
    }

    public bool PuedeJugar()
    {
        return true;
    }
}