namespace EstructurasLibrary;


public class Servidor : IComparable<Servidor>
{
    private MyQueue<Pedido> _pedidos;
    public MyQueue<Pedido> Pedidos
    {
        get { return _pedidos; }
        set { _pedidos = value; }
    }

    private int maxPedidos;
    public int MaxPedidos
    {
        get { return maxPedidos; }
        set { maxPedidos = value; }
    }

    private int _cantPedidosPend;
    public int CantPedidosPend
    {
        get { return _cantPedidosPend; }
        set { _cantPedidosPend = value; }
    }

    public Servidor(int maxPedidos)
    {
        _pedidos = new MyQueue<Pedido>();

        MaxPedidos = maxPedidos;

        _cantPedidosPend = 0;
    }

    public void EncolarPedido(Pedido nuevo)
    {
        _pedidos.Enqueue(nuevo);

        _cantPedidosPend++;
    }

    public Pedido Procesar()
    {
        if (_pedidos.IsEmpty())
        {
            throw new Exception("No hay pedidos");
        }

        _cantPedidosPend--;

        return _pedidos.Dequeue();
    }

    public int CompareTo(Servidor? other)
    {
        if (other == null)
        {
            return 1;
        }

        return CantPedidosPend.CompareTo(other.CantPedidosPend);
    }

    public override string ToString()
    {
        return $"Servidor - Pedidos pendientes: {CantPedidosPend}";
    }
}