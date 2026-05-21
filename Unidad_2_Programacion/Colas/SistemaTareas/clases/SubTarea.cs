namespace EstructurasLibrary;

public class Subtarea
{
    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    private string _descripcion;
    public string Descripcion
    {
        get { return _descripcion; }
        set { _descripcion = value; }
    }

    public Subtarea(int id, string descripcion)
    {
        Id = id;
        Descripcion = descripcion;
    }
}