namespace ejemplo_poo.Dominio;

public class Alumno : Persona
{
    public Alumno(string nombre, string apellido, string email, string legajo, float promedio, int edad) 
    : base(nombre, apellido, email, edad)
    {
        this.Legajo = legajo;
        this.Promedio = promedio;
    }
    public string Legajo { get; set; } = "";
    public float Promedio { get; set; } = 0;

    public override string Saludar()
    {
        return $"{base.Saludar()} soy un alumno con legajo ({this.Legajo}) y promedio {this.Promedio} edad {this.Edad}";
    }


    //sobre carga 
    public string Saludar(string mensaje)
    {
        {
            return $"Hola, soy un alumno con legajo ({this.Legajo}) mi nombre es: {this.GetNombre()} {this.GetApellido()} mi email es: {this.GetEmail()} {mensaje}";
        }
    }

    public bool EstoyPresente()
    {
        return true;
    }
}