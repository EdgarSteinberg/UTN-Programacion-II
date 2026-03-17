

/* Crear una clase Persona que tenga los atributos públicos nombre y apellido.
● Crear una instancia y asignarle valores.
● Mostrar por pantalla los valores asignados.
 */


/* Persona objPersona = new Persona();

objPersona.Nombre = "Edgar";
objPersona.Apellido = "Steinberg";

Console.WriteLine(objPersona.Saludar());
 */


class Persona
{
    public string _nombre = "";
    public string _apellido = "";

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public string Apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }

    public string Saludar()
    {
        return $"Nombre: {Nombre}, Apellido: {Apellido}";
    }
}