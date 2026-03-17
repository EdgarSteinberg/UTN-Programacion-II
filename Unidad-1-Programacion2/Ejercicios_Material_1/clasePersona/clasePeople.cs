/* Crear una clase Persona que tenga los atributos privados nombre y apellido, con sus setters y
getters.
● Crear una clase llamada Visitante con los mismos atributos.
● Crear una clase Guardia con los mismos atributos.
● Crear una instancia de cada una de las clases y asignarle valores.
● Mostrar por pantalla los valores.
 */



/* Crear una clase Persona que tenga los atributos privados nombre y apellido, con sus setters y
getters. */
class People
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
}


//Crear una clase llamada Visitante con los mismos atributos.
class Visitante : People
{
    
}

//Crear una clase Guardia con los mismos atributos.
class Guardia : People
{
    
}