Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");

/* Persona unaPersona = new Persona(); */
/* Persona unaPersona = new Alumno(); */

Alumno unaPersona = new Alumno();

unaPersona.SetNombre("Juan");
unaPersona.SetApellido("Perez");
unaPersona.SetEmail("jaun.perez@example.com");
unaPersona.Legajo = "N100";
unaPersona.Promedio = 8.5F;

Console.WriteLine(unaPersona.Saludar());

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
    /*  public virtual string Saludar() //Virtual me permite sobrescribir
     {
         return $"Hola mi nombre es {this.nombre} {this.apellido} y mi email es {this.email}";
     } */

    public abstract string Saludar();


}

public class Alumno : Persona
{
    public string Legajo { get; set; } = "";
    public float Promedio { get; set; }

    public override string Saludar()
    {
        return $"Hola, soy un alumno ({this.Legajo}) y mi nombre es {this.GetNombre()} {this.GetApellido()} y mi email {this.GetEmail()}";
    }
}