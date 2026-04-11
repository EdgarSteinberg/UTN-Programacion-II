using ejemplo_poo.Exptions;
namespace ejemplo_poo.Dominio;

// Las clases abstractas no se pueden instanciar 
public abstract class Persona
{

    private string nombre = "";
    private string apellido = "";
    private string email = "";
    private int edad = 0;

    public int Edad
    {
        get{ return edad;}
        set{ edad = value; }
    }
    public string GetNombre()
    {
      /*   if (string.IsNullOrEmpty(this.nombre))
        {
            throw new Exception("Falta el Nombre");
        }
        return this.nombre; */
        if (string.IsNullOrEmpty(this.nombre))
        {
            throw new DataMisalignedException();
        }
        return this.nombre;
    }


    public Persona(string nombre, string apellido, string email, int edad)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.email = email;
        this.edad = edad;
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
        if (string.IsNullOrEmpty(this.apellido))
        {
            throw new Exception("Falta Apeelido");
        }
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
