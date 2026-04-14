namespace Ejercicios.clases;

public class Comoda : Producto
{
    private int _cantidadDeCajones;

    public int CantidadDeCajones
    {
        get { return _cantidadDeCajones; }
        set { _cantidadDeCajones = value; }
    }

    private double _superficie;

    public double Superficie
    {
        get { return _superficie; }
        set { _superficie = value; }
    }

    public Comoda(int id, string desc, double dim, int cajones, double superficie)
    {
        NumeroId = id;
        Descripcion = desc;
        Dimensiones = dim;
        CantidadDeCajones = cajones;
        Superficie = superficie;

    }
}