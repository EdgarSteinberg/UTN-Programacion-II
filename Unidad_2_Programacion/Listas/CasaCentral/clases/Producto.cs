namespace EstructurasLibrary;

public class Producto : IComparable<Producto>
{
    public int CompareTo(Producto? other)
    {
        return Id_producto.CompareTo(other.Id_producto);
    }
    private string _id_producto;
    public string Id_producto
    {
        get { return _id_producto; }
        set { _id_producto = value; }
    }

    public override bool Equals(object? obj)
    {
        Producto? producto = obj as Producto;

        if (producto == null)
        {
            return false;
        }

        return Id_producto == producto.Id_producto;
    }

    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private string _descripcion;
    public string Descripcion
    {
        get { return _descripcion; }
        set { _descripcion = value; }
    }

    private int _stock;
    public int Stock
    {
        get { return _stock; }
        set { _stock = value; }
    }

    private int _precio;
    public int Precio
    {
        get { return _precio; }
        set { _precio = value; }
    }

    public Producto(string id_producto, string nombre, string descripcion, int precio, int stock)
    {
        Id_producto = id_producto;
        Nombre = nombre;
        Descripcion = descripcion;
        Precio = precio;
        Stock = stock;
    }
}