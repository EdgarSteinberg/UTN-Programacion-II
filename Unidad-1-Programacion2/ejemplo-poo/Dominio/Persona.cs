namespace ejemplo_poo.Dominio;

// Las clases abstractas no se pueden instanciar 
public abstract class Persona
{

    private string nombre = "";
    private string apellido = "";
    private string email = "";

    public string GetNombre()
    {
        return this.nombre;
    }

    public Persona()
    {
        this.nombre = "Sin nombre";
        this.apellido = "Sin apellido";
        this.email = "Sin email";
    }

    public Persona(string nombre, string apellido, string email)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.email = email;
    }

    public void SetNombre(string nombre)
    {
        if (nombre == "Juan")
        {
            nombre = "John";
        }
        this.nombre = nombre;
    }

    public string GetApellido()
    {
        return this.apellido;
    }

    public void SetApellido(string apellido)
    {
        this.apellido = apellido;
    }

    public string GetEmail()
    {
        return this.email;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }


    //Comportamiento Metodo
    public virtual string Saludar() //Virtual me permite sobrescribir
    {
        return $"Hola mi nombre es {this.nombre} {this.apellido} y mi email es {this.email}";
    }

    /* public abstract string Saludar(); */


}
