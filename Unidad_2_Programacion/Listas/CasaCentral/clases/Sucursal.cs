namespace EstructurasLibrary;


public class Sucursal
{
    private MyList<Producto> _productos;

    public MyList<Producto> Productos
    {
        get { return _productos; }
        set { _productos = value; }
    }

    private string _id_sucursal;

    public string Id_sucursal
    {
        get { return _id_sucursal; }
        set { _id_sucursal = value; }
    }

   
    public Sucursal(string id_sucursal)
    {
        _id_sucursal = id_sucursal;
        _productos = new MyList<Producto>();
    }

    public void AgregarProducto(Producto pr, int cant)
    {
        var encontrado = _productos.Search(pr);

        if (encontrado != null)
        {
            encontrado.Value.Stock += cant;
            return;
        }

        pr.Stock = cant;
       
        _productos.Push(pr);
    }

    public void Ventas(Producto pr, int cant)
    {
        var encontrado = _productos.Search(pr);

        if (encontrado != null)
        {
            if (encontrado.Value.Stock >= cant)
            {
                encontrado.Value.Stock -= cant;
            }
        }
    }

    //Devolucion
    public void RestituirProducto(Producto pr, int cant)
    {
        var encontrado = _productos.Search(pr);

        if (encontrado != null)
        {
            encontrado.Value.Stock += cant;
        }
    }


    public string ObtenerCodigoCompleto(Producto pr)
    {
        return Id_sucursal + "-" + pr.Id_producto;
    }


}