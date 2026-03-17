/* Crear una clase Articulo que tenga los atributos privados marca y modelo.
● Crear métodos públicos para la asignación de valores.
● Crear una instancia y asignarle valores.
● Notar que no es posible mostrar los valores por pantalla y analizar el motivo por lo que
esto ocurre.
 */

class Articulo
{
    private string marca = "";
    private string modelo = "";

    public void SetMarca(string nuevaMarca)
    {
        marca = nuevaMarca;
    }

    public void SetModelo(string nuevoModelo)
    {
        modelo = nuevoModelo;
    }


    public void MostrarInfo()
    {
        Console.WriteLine($"Marca: {marca}, Modelo: {modelo}");
    }
}

/* No es posible mostrar los valores porque los atributos marca y modelo son privados, por lo que solo pueden ser accedidos desde dentro de la clase Articulo. */