 
namespace Ejercicios.clases;

public abstract class Vehiculo
{
    protected List<Producto> _carga = new List<Producto>();

    public List<Producto> Carga
    {
        get { return _carga; }
        set { _carga = value; }
    }

    private int _capacidadMaxima;

    public int CapacidadMaxima
    {
        get { return _capacidadMaxima; }
        set { _capacidadMaxima = value; }
    }

    public void CargarProducto(Producto p)
    {
        if (_carga.Count < CapacidadMaxima)
            _carga.Add(p);
    }

    public void ListarProductos()
    {
        foreach (Producto item in _carga)
        {
            Console.WriteLine(item.Descripcion);
        }
    }
}