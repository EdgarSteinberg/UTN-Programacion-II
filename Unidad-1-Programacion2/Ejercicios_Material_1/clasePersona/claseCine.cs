/* 4. Crear una clase Cine que tenga los atributos privados película y horario:
● Crear métodos públicos para la asignación y recuperación de valores.
● Crear un método público obtenerCartelera() que devuelva el nombre de la película y el
horario.
● Crear una instancia y asignarle valores.
● Mostrar por pantalla los valores. */


class Cine
{
    private string pelicula = "";
    private int horario = 0;

    public string Pelicula
    {
        get { return pelicula; }
        set { pelicula = value; }
    }

    public int Horario
    {
        get { return horario; }
        set { horario = value; }
    }

    public string ObtenerCartelera()
    {
        return $"Película: {this.pelicula}, Horario: {this.horario}";
    }
}
