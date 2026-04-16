namespace Ejercicios.clases;


public class Micro
{
    public Micro(int vol, int cantidadSentados, int cantidadParados)
    {
        Volumen = vol;
        CantidadSentados = cantidadSentados;
        CantidadParados = cantidadParados;
        Pasajeros = new List<Persona>();
    }
    private int _cantidadSentados;
    public int CantidadSentados
    {
        get { return _cantidadSentados; }
        set { _cantidadSentados = value; }
    }

    private int _cantidadParados;
    public int CantidadParados
    {
        get { return _cantidadParados; }
        set { _cantidadParados = value; }
    }

    private int _volumen;

    public int Volumen
    {
        get { return _volumen; }
        set { _volumen = value; }
    }


    /* private List<Persona> _pasajeros = new List<Persona>(); */
    private List<Persona> _pasajeros;
    public List<Persona> Pasajeros
    {
        get { return _pasajeros; }
        set { _pasajeros = value; }
    }

    public bool HayLugar()
    {
        return (CantidadParados + CantidadSentados) > Pasajeros.Count;
    }

    public int LugaresLibres()
    {
        return (CantidadSentados + CantidadParados) - Pasajeros.Count;
    }

    public bool HayLugarSentado()
    {
        return CantidadSentados > Pasajeros.Count;
    }

    public void Subir(Persona persona)
    {
        if (persona.AceptaSubir(this))
        {
            Console.WriteLine("La Persona Subio Al Micro");
            Pasajeros.Add(persona);
        }
        else
        {
            Console.WriteLine("La Persona No Ha Subio Al Micro");

        }
    }
}