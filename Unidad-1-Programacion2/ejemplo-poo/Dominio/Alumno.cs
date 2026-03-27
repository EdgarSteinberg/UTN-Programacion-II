namespace ejemplo_poo.Dominio;

public class Alumno : Persona
{
    public Alumno(string legajo, float promedio)
    {
        this.Legajo = legajo;
        this.Promedio = promedio;
    }
    public string Legajo { get; set; } = "";
    public float Promedio { get; set; } = 0;

    public override string Saludar()
    {
        return $"Hola, soy un alumno con legajo ({this.Legajo}) mi nombre es: {this.GetNombre()} {this.GetApellido()} mi email es: {this.GetEmail()}";
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