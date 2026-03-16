
/* Persona objPersona = new Persona();
objPersona.Nombre = "Diego";
objPersona.Apellido = "Maradona"; */

/* objPersona.Saludar(); */
/* Console.WriteLine(objPersona.Saludar()); */

Profesor objProfesor = new Profesor();
objProfesor.Nombre = "Juan";
objProfesor.Apellido = "Tomaselli";
objProfesor.NumeroDeLegajo = 1234;

Alumno objAlumno = new Alumno();
objAlumno.Nombre = "Edgar";
objAlumno.Apellido = "Steinberg";
objAlumno.NumeroDeMatricula = 12345;


// Con costructor 

Profesor objProfesor2 = new Profesor("Abert", "Stein", 4234);

Console.WriteLine(objProfesor.Saludar());
Console.WriteLine(objProfesor2.Saludar());

Console.WriteLine(objAlumno.Saludar());


Examen objExamen = new Examen(objAlumno, objProfesor2, DateTime.Now);
Console.WriteLine(objExamen);

public abstract class Persona
{

    private string nombre = ""; // Atribuo

    private string apellido = ""; // Atribuo

    public string Nombre
    {
        get { return nombre; }

        set { nombre = value; }
    }


    public string Apellido    //Property
    {
        get { return apellido; }

        set { apellido = value; }
    }

    public abstract string Saludar(); // Metodo
    /*   {
          return $"Hola mi nombre es {this.nombre} y apellido {this.apellido}";
      } */
}


public class Profesor : Persona
{
    private int numeroDeLegajo; // Atribuo


    public int NumeroDeLegajo    //Property
    {
        get { return numeroDeLegajo; }

        set { numeroDeLegajo = value; }
    }

    public override string Saludar()
    {
        return $"Hola soy el profesor {this.Nombre} {this.Apellido} mi numero de legajo {this.numeroDeLegajo}";
    }

    // Constructor vacío
    public Profesor() { }


    public Profesor(string nombre, string apellido, int numeroDeLegajo)
    {
        Nombre = nombre;
        Apellido = apellido;
        NumeroDeLegajo = numeroDeLegajo;
    }
}

public class Alumno : Persona
{
    private int numeroDeMatricula; // Atribuo

    //Property
    public int NumeroDeMatricula    //Property
    {
        get { return numeroDeMatricula; }

        set { numeroDeMatricula = value; }
    }

    public override string Saludar()
    {
        return $"Hola soy el alumno {this.Nombre} {this.Apellido} mi numero de matricula es {this.NumeroDeMatricula}";
    }
}


public class Examen
{
    /// <summary>
    /// Constructor de la clase Examen . Recibe un objeto Alumno , un objeto Profesor y una fecha
    /// </summary>
    /// <param name="alumno"> objeto Alumno </param>
    /// <param name="profesor"> un objeto Profesor</param>
    /// <param name="fecha"> una fecha </param>
    public Examen(Alumno alumno, Profesor profesor, DateTime fecha)
    {
        Alumno = alumno;
        Profesor = profesor;
        /*   Fecha = fecha; */
        this._fecha = fecha; // cargamos el atributo _fecha con el valor de fecha que recibimos del parametro
    }

    // Constructor vacío
    public Examen() { }
    
    private float _nota;

    public float Nota
    {
        get { return _nota; }
        set { Nota = value; }
    }

    private Alumno _alumno;

    public Alumno Alumno
    {
        get { return _alumno; }
        set { _alumno = value; }
    }

    private DateTime _fecha;

    private DateTime Fecha
    {
        get { return _fecha; }

        set { _fecha = value; }
    }

    private Profesor _profesor
    {
        get { return _profesor; }

        set { _profesor = value; }
    }
}