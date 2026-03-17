/* Continuando con el ejemplo anterior, realizar las siguientes modificaciones:
● Agregar en Persona el método presentarse() que devuelva nombre y apellido de la
persona.
● Crear una instancia de cada una de las clases y asignarle valores.
● Mostrar por pantalla los valores.
● Sobreescribir el método presentarse() en la clase Guardia de modo tal que devuelva el
siguiente mensaje “Hola, mi nombre es <nombre y apellido> y soy el guardia.” Donde
<nombre y apellido> debe ser reemplazado por el nombre y apellido del guardia.
● Mostrar por pantalla el resultado de invocar el método presentarse() y advertir que la
implementación en la clase Guardia tiene precedencia sobre la de su padre */


class People_1
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

    /* ● Sobreescribir el método presentarse() en la clase Guardia de modo tal que devuelva el
   siguiente mensaje “Hola, mi nombre es <nombre y apellido> y soy el guardia.” Donde
   <nombre y apellido> debe ser reemplazado por el nombre y apellido del guardia. */

    public virtual void Presentarse()
    {
        Console.WriteLine($"Mi nombre es: {this.Nombre} y mi apellido es {this.Apellido}");
    }
}


//Crear una clase llamada Visitante con los mismos atributos.
class Visitante_1 : People_1
{
    public override void Presentarse()
    {
        Console.WriteLine($"Mi nombre es: {this.Nombre}, y mi apellido es {this.Apellido} soy el visitante");
    }
}

//Crear una clase Guardia con los mismos atributos.
class Guardia_1 : People_1
{
    public override void Presentarse()
    {
        Console.WriteLine($"Mi nombre es: {this.Nombre}, y mi apellido es {this.Apellido} soy el guardia");
    }
}