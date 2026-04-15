Objeto mamushkaGrande = new Objeto("Madera", 10);
Objeto mamushkaMediana = new Objeto("Madera", 7);
Objeto mamushkaChica = new Objeto("Madera", 4);

mamushkaGrande.AgregarContenido(mamushkaMediana);
mamushkaMediana.AgregarContenido(mamushkaChica);



Objeto portafolio = new Objeto("Cuero", 5);

Objeto botiquin = new Objeto("Plastico", 12);

Objeto gasa = new Objeto("Textil", 1);
Objeto aguaOxigenada = new Objeto("Liquido", 2);

botiquin.AgregarContenido(gasa);
botiquin.AgregarContenido(aguaOxigenada);

Objeto bolsa = new Objeto("Cuero", 4);

Objeto peine = new Objeto("Plastico", 1);

bolsa.AgregarContenido(peine);
bolsa.AgregarContenido(botiquin);

mamushkaGrande.MostrarObjeto();
portafolio.MostrarObjeto();
botiquin.MostrarObjeto();
bolsa.MostrarObjeto();

public class Objeto
{
    public Objeto(string mat, int vol)
    {
        Material = mat;
        Volumen = vol;
    }

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

    public void AgregarContenido(Objeto obj)
    {
        _contenido.Add(obj);
        obj.Contenedor = this;
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