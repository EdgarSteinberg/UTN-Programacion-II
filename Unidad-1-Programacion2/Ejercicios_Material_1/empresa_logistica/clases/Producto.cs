namespace Ejercicios.clases;

public class Producto
{
    private string _descripcion;

    public string Descripcion
    {
        get { return _descripcion; }
        set { _descripcion = value; }
    }

    private double _dimensiones;

    public double Dimensiones
    {
        get { return _dimensiones; }
        set { _dimensiones = value; }
    }

    private int _numeroId;

    public int NumeroId
    {
        get { return _numeroId; }
        set { _numeroId = value; }
    }

 
}