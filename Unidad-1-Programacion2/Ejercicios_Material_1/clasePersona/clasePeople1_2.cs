/* 12. Continuando con el ejemplo anterior, realizar las siguientes modificaciones:
● Modificar la clase Guardia para que el método público controlarDocumento() devuelva
el mensaje “Adelante <nombre completo del visitante> con dni <dni>” reemplazando
respectivamente con el nombre completo del visitante y su dni.
● Crear una instancia de cada una de las clases y asignarle valores.
● Mostrar por pantalla los valores.
● Analizar si es posible pasar un único parámetro al método controlarDocumento() y
estudiar las ventas y desventajas que tendría asociado. */


class People_1_2
{
    private string nombre = "";

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
class Visitante3 : People_1_2
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


/* ● Modificar la clase Guardia para que el método público controlarDocumento() devuelva
el mensaje “Adelante <nombre completo del visitante> con dni <dni>” reemplazando
respectivamente con el nombre completo del visitante y su dni. */
class Guardian3 : People_1_2
{
    public override void Presentarse()
    {
        Console.WriteLine($"Hola, mi nombre es {this.Nombre} {this.Apellido} y soy el Guardian2.");
    }

    public string ControlarDocumento(int dni, string nombre, string apellido)
    {
        return $"Adelante {nombre} {apellido} con DNI {dni}";
    }
}