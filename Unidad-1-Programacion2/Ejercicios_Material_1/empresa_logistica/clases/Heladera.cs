namespace Ejercicios.clases;

public class Heladera : Producto
{
    private int _voltaje;

    public int Voltaje
    {
        get { return _voltaje; }
        set { _voltaje = value; }
    }

    private bool _tieneFreezer;

    public bool TieneFreezer
    {
        get { return _tieneFreezer; }
        set { _tieneFreezer = value; }
    }

    public Heladera(int id, string desc, double dim, int voltaje, bool freezer)
    {
        NumeroId = id;
        Descripcion = desc;
        Dimensiones = dim;
        Voltaje = voltaje;
        TieneFreezer = freezer;
    }
}