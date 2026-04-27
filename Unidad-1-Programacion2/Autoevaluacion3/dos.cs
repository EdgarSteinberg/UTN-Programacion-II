//POLIMORFISMO POR INTERFAZ

/* 
varias clases distintas usan el mismo “contrato”
interface IFlyable
{
    void Fly();
} */

IFlyable[] thingsThatFly = [new Bird(), new Plane()];

foreach(IFlyable item in thingsThatFly)
{
    item.Fly();
}

interface IFlyable
{
    void Fly();
}

class Bird : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("El pajaro vuela.");
    }
}

class Plane : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("El avion vuela.");
        
    }
}


