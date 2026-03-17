/*5. Crear una clase Cine que tenga los atributos privados película y horario.
● Crear métodos públicos para la asignación y recuperación de valores.
● Crear una instancia y asignarle valores.
● Mostrar por pantalla los valores.
● Crear una segunda instancia y asignarle valores.
● Mostrar por pantalla los valores.
● Cambiar los valores de la primera instancia.
● Mostrar en pantalla los valores de ambas instancias; concluir que la instrucción new crea
objetos distintos.
 */

class CineCartelera
{
    // Atributos privados
    private string pelicula2 = "";

    private int horario2 = 0;


    //Metodos publicos para asginacion y recuperacion de valores
    public string Pelicula2
    {
        get { return pelicula2; }
        set { pelicula2 = value; }
    }

    public int Horario2
    {
        get { return horario2; }
        set { horario2 = value; }
    }
 
    //Mostrar por pantalla los valores
    public void MostrarDatos()
    {
        Console.WriteLine($"La pelicula2: es {this.pelicula2} y a la hora : {this.horario2}");
    }


    // Crear una segunda instancia y asignarle valores.

}