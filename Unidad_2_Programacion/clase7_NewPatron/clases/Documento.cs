namespace EstructurasLibrary;

public class Documento
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    
    private string _texto;
    public string Texto
    {
        get { return _texto; }
        set { _texto = value; }
    }
    public Documento(string nombre, string texto)
    {
        Nombre = nombre;
        Texto = texto;
    }
    
}