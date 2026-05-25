namespace EstructurasLibrary;

public class Balanceador
{
    private int _maxPedidos;
    public int MaxPedidos
    {
        get { return _maxPedidos; }
        set { _maxPedidos = value; }
    }

    private MyList<Servidor> _servidores;
    public MyList<Servidor> Servidores
    {
        get { return _servidores; }
        set { _servidores = value; }
    }


    public Balanceador(int maxPedidos)
    {
        _servidores = new MyList<Servidor>();

        MaxPedidos = maxPedidos;
    }
    public Servidor ObtenerServidorMenorCarga()
    {
        Servidor? menor = _servidores.RemoveFirst();

        if (menor == null)
        {
            throw new Exception("No hay servidores");
        }

        _servidores.InsertFirst(menor);

        return menor;
    }

    public Servidor CrearServidor()
    {
        Servidor nuevo = new Servidor(_maxPedidos);

        _servidores.InsertOrdered(nuevo);

        return nuevo;
    }

    public void RecibirPedido(Pedido pedido)
    {
        Servidor servidor;

        try
        {
            servidor = ObtenerServidorMenorCarga();

            if (servidor.CantPedidosPend >= servidor.MaxPedidos)
            {
                servidor = CrearServidor();
            }
        }
        catch
        {
            servidor = CrearServidor();
        }

        servidor.EncolarPedido(pedido);

        _servidores.Sort();
    }

    public void MostrarServidores()
    {
        _servidores.Print();
    }
}