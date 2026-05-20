namespace EstructurasLibrary;

public class Cliente
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public Cliente(string nombre)
    {
        Nombre = nombre;
    }
}