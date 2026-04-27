//Polimorfismo por herencia  una clase base + clases hijas

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Sonido genérico");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Guau");
    }
}


//Polimorfismo por sobrecarga mismo método, distintos parámetros

class Calculadora
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public int Sumar(int a, int b, int c)
    {
        return a + b + c;
    }
}


//Polimorfismo por composición    una clase usa otras clases dentro
class Motor
{
    public void Encender()
    {
        Console.WriteLine("Motor encendido");
    }
}

class Auto
{
    private Motor motor = new Motor();

    public void Arrancar()
    {
        motor.Encender();
    }
}