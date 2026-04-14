namespace Ejercicios.clases;

public class Lavarropa : Producto
{
    private int _voltaje;

    public int Voltaje
    {
        get { return _voltaje; }
        set { _voltaje = value; }
    }

    private double _carga;

    public double Carga
    {
        get { return _carga; }
        set { _carga = value; }
    }

    private double _revoluciones;

    public double Revoluciones
    {
        get { return _revoluciones; }
        set { _revoluciones = value; }
    }

    public Lavarropa(int id, string desc, double dim, int voltaje, double carga, double revoluciones)
    {
        NumeroId = id;
        Descripcion = desc;
        Dimensiones = dim;
        Voltaje = voltaje;
        Carga = carga;
        Revoluciones = revoluciones;
    }
}