namespace ejemplo_poo.Dominio;

public class Docente : Persona
{
    private string _materia = "";

    public string Materia
    {
        get { return _materia; }
        set { _materia = value; }

    }

    public int Horas { get; set; }
    public Docente(string materia, int horas)
    {
        this.Materia = materia;
        this.Horas = horas;
    }

    public override string Saludar()
    {
        return $"Hola, soy el docente de {this.Materia} Mi nombre es {this.GetNombre()} {this.GetApellido()} y mi email es {this.GetEmail()})";
    }
}