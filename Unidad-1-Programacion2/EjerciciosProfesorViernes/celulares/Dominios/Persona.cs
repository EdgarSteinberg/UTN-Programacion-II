namespace celulares.Dominio;


public class Persona
{
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    // ASOCIACION COMPOSICION
    private Celular celular;
    public Celular Celular
    {
        get { return celular; }
        set { celular = value; }
    }
}