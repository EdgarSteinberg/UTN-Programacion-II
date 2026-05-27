namespace EstructurasLibrary;

public class Carpeta : Elemento
{
    public Carpeta(string nombre, int tamano) : base(nombre, tamano)
    {
        this.Elementos = new List<Elemento>();
    }

    private List<Elemento> _elementos;
    public List<Elemento> Elementos
    {
        get { return _elementos; }
        set { _elementos = value; }
    }

    public override int DevolverTamano()
    {
        int tamanoTotal = 0;

        foreach (Elemento elemento in this._elementos)
        {
            tamanoTotal += elemento.DevolverTamano();
        }

        return tamanoTotal + this.Tamano;
    }

    public void Agregar(Elemento elemento)
    {
        this._elementos.Add(elemento);
    }

    public void Remover(Elemento elemento)
    {
        this._elementos.Remove(elemento);
    }
}