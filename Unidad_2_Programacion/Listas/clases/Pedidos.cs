namespace EstructurasLibrary;


public class Pedido
{
    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    private int _ciclos;
    public int Ciclos
    {
        get { return _ciclos; }
        set { _ciclos = value; }
    }

    private string _tipo;
    public string Tipo
    {
        get { return _tipo; }
        set { _tipo = value; }
    }

    public Pedido(int id, int ciclos, string tipo)
    {
        Id = id;
        Ciclos = ciclos;
        Tipo = tipo;
    }

    public override string ToString()
    {
        return $"Pedido {Id} - {Tipo}";
    }
}