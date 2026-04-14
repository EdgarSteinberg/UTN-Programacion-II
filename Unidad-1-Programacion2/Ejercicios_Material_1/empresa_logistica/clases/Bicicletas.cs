namespace Ejercicios.clases;

public class Bicicleta : Producto
{
    private int _rodado;

    public int Rodado
    {
        get { return _rodado; }
        set { _rodado = value; }
    }

    private bool _esElectrica;

    public bool EsElectrica
    {
        get { return _esElectrica; }
        set { _esElectrica = value; }
    }

    private int _cantidadDeCambios;

    public int CantidadDeCambios
    {
        get { return _cantidadDeCambios; }
        set { _cantidadDeCambios = value; }
    }
    public Bicicleta(int id, string desc, double dim, int rodado, bool electrica, int cambios)
    {
        NumeroId = id;
        Descripcion = desc;
        Dimensiones = dim;
        Rodado = rodado;
        EsElectrica = electrica;
        CantidadDeCambios = cambios;
    }
}