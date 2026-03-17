/* 11. Continuando con el ejemplo anterior, realizar las siguientes modificaciones:
● Agregar en Visitante el atributo privado dni (numérico) con sus setters y getters
correspondientes.
● Agregar en Guardia el método público controlarDocumento() que reciba como
parámetro el dni de la persona y devuelva el mensaje “Adelante persona con dni <dni>”
donde <dni> es el valor recibido por parámetro.
● Crear una instancia de cada una de las clases y asignarle valores.
● Mostrar por pantalla los valores. */



class People_1_1
{
    private string nombre ="";

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    private string apellido = "";

    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }

    public virtual void Presentarse()
    {
        Console.WriteLine($"Hola,mi nombre es :{this.nombre} y mi apellido es: {this.apellido}");
    }
}

/* ● Agregar en Visitante el atributo privado dni (numérico) con sus setters y getters
correspondientes. */
class Visitante2 : People_1_1
{
    private int dni = 0;

    public int Dni
    {
        get { return dni; }
        set { dni = value; }
    }

    public override void Presentarse()
    {
        Console.WriteLine($"Hola, mi nombre es {this.Nombre} {this.Apellido} y soy el visitante.");
    }
}


/* ● Agregar en Guardia el método público controlarDocumento() que reciba como
parámetro el dni de la persona y devuelva el mensaje “Adelante persona con dni <dni>”
donde <dni> es el valor recibido por parámetro. */
class Guardian2 : People_1_1
{
    public override void Presentarse()
    {
        Console.WriteLine($"Hola, mi nombre es {this.Nombre} {this.Apellido} y soy el Guardian2.");
    }

    public string ControlarDocumento(int dni)
    {
        return $"Adelante persona con dni {dni}";
    }
}