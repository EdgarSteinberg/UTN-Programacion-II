public abstract class Bebida
{
    private string _descripcion;
    public string Descripcion
    {
        get { return _descripcion; }
        set { _descripcion = value; }
    }
    
    public abstract double Costo();
}