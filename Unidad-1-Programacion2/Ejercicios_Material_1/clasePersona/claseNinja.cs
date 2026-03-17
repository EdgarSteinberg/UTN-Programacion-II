/*
Crear una clase Ninja con las variables privadas arteMarcial, arma, fuerza (entero) y salto
(entero).
● Crear setters y getters manualmente.
● Crear una función saltar() que reciba un parámetro multiplicador (entero); imprimir
por consola salto x parámetro.
● Crear la función ataque() que imprima por consola el arma que usa el ninja y el
arte marcial.
● Crear dos instancias de Ninja, asignar distintos valores para cada uno de los
atributos e invocar las funciones saltar() y ataque().
*/

//Clase Ninja
class Ninja
{
    //variables privadas arteMarcial, arma, fuerza (entero) y salto (entero).
    //Crear setters y getters manualmente.
    private string arteMarcial = "";

    public string ArteMarcial
    {
        get { return arteMarcial; }
        set { arteMarcial = value; }
    }

    private string arma = "";

    public string Arma
    {
        get { return arma; }
        set { arma = value; }
    }

    private int fuerza = 0;

    public int Fuerza
    {
        get { return fuerza; }
        set { fuerza = value; }
    }

    private int salto = 0;

    public int Salto
    {
        get { return salto; }
        set { salto = value; }
    }

    /* Crear una función saltar() que reciba un parámetro multiplicador (entero); imprimir por consola salto x parámetro. */
    /*     public void Salto(int multiplicador)
    {
        Console.WriteLine($"Salto por parametro es = {this.salto * multiplicador}");
    } */
    public void Saltar(int multiplicador)
    {
        int resultado = this.salto * multiplicador;
        Console.WriteLine($"Salto por parametro: {this.salto} * {multiplicador} = {resultado}");
    }

    //Crear la función ataque() que imprima por consola el arma que usa el ninja y el arte marcial.

    public void Ataque()
    {
        Console.WriteLine($"El arma que utiliza el Ninja es: {this.arma} y su arte marcial es: {this.arteMarcial} ");
    }
}