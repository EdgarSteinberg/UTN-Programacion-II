

public class Objeto
{
    private string _material;
    public string Material
    {
        get { return _material; }
        set { _material = value; }
    }

    private int _volumen;
    public int Volumen
    {
        get { return _volumen; }
        set { _volumen = value; }
    }

    private List<Objeto> _contenido = new List<Objeto>();
    public List<Objeto> Contenido
    {
        get { return _contenido; }
        set { _contenido = value; }
    }

    private Objeto _contenedor;
    public Objeto Contenedor
    {
        get { return _contenedor; }
        set { _contenedor = value; }
    }

    // 🔥 Método para mostrar
    public void MostrarObjeto()
    {
        Console.WriteLine($"Material: {Material}");
        Console.WriteLine($"Volumen: {Volumen}");

        foreach (var item in _contenido)
        {
            Console.WriteLine($"Contiene: {item.Material}");
        }

        Console.WriteLine($"Tipo: {Tipo()}");
    }

    // 🔥 Método clave
    public TipoDeObjeto Tipo()
    {
        bool contiene = _contenido.Count > 0;
        bool estaContenido = _contenedor != null;

        if (!contiene && !estaContenido)
            return TipoDeObjeto.Simple;

        if (contiene && !estaContenido)
            return TipoDeObjeto.Contenedor;

        if (!contiene && estaContenido)
            return TipoDeObjeto.Contenido;

        return TipoDeObjeto.Sambuchito;
    }
}


public enum TipoDeObjeto
{
    Simple,
    Contenedor,
    Contenido,
    Sambuchito
}