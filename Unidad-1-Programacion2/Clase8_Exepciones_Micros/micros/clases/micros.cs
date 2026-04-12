namespace Clase8_Exepciones_Micros.clases;

/* public class Micros */
{
    private List<Persona> _personas = new List<Persona>();
    public List<Persona> Personas
    {
        get { return _personas; }
        set { _personas = value; }
    }

    public int _capacidadTotal;
    public int CapacidadTotal
    {
        get { return _capacidadTotal; }
        set { _capacidadTotal = value; }
    }

    private double _volumen;
    public double Volumen
    {
        get { return _volumen; }
        set { _volumen = value; }
    }

    private int _sentados;
    public int Sentados
    {
        get { return _sentados; }
        set { _sentados = value; }
    }

    private int _parados;
    public int Parados
    {
        get { return _parados; }
        set { _parados = value; }
    }

    // METODOS
    /* public bool HayLugar()
    {
        return this._personas.Count < this.Capacidad;
    } */
    public int CapacidadTotal()
{
    return _sentados + _parados;
}
    public bool HayLugar()
    {
        return LugaresLibres() > 0;
    }
    public int LugaresLibres()
    {
        return this.Capacidad - this._personas.Count;
    }

    public void Subir(Persona p)
    {
        if (HayLugar() && p.AceptaSubir(this))
        {
            _personas.Add(p);
        }
        else
        {
            throw new Exception("No se puede subir la persona");
        }
    }

    public int CantidadAsientos()
    {
        return LugaresLibres();
    }

    public bool Bajar(Persona p)
    {
        if (_personas.Count > 0)
        {
            return _personas.Remove(p);
        }
        else
        {
            throw new Exception("El micro está vacío");
        }
    }
    public bool PuedeSubir(Persona p)
    {
        return HayLugar() && p.AceptaSubir(this);
    }


    public Persona SubioPrimero()
    {
        if (_personas.Count > 0)
        {
            return _personas[0];
        }
        return null;
    }
}

public class Micro
{
    private List<Persona> _personas = new List<Persona>();

    public List<Persona> Personas
    {
        get { return _personas; }
    }

    public int Sentados { get; set; }   // capacidad sentados
    public int Parados { get; set; }    // capacidad parados
    public double Volumen { get; set; }

    // 🔹 Capacidad total
    public int CapacidadTotal()
    {
        return Sentados + Parados;
    }

    // 🔹 Lugares libres (total)
    public int LugaresLibres()
    {
        return CapacidadTotal() - _personas.Count;
    }

    // 🔹 Hay lugar
    public bool HayLugar()
    {
        return LugaresLibres() > 0;
    }

    // 🔹 Asientos libres (para Fiaca)
    public int CantidadAsientos()
    {
        return Sentados - _personas.Count;
    }

    // 🔹 Puede subir
    public bool PuedeSubir(Persona p)
    {
        return HayLugar() && p.AceptaSubir(this);
    }

    // 🔹 Subir persona
    public void Subir(Persona p)
    {
        if (PuedeSubir(p))
        {
            _personas.Add(p);
        }
        else
        {
            throw new Exception("No se puede subir la persona");
        }
    }

    // 🔹 Bajar persona
    public bool Bajar(Persona p)
    {
        if (_personas.Count == 0)
            throw new Exception("El micro está vacío");

        return _personas.Remove(p);
    }

    // 🔹 Primero que subió
    public Persona SubioPrimero()
    {
        return _personas.Count > 0 ? _personas[0] : null;
    }
}