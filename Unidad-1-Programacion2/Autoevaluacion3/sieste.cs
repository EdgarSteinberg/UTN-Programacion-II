Car myCar = new Car("V8");
myCar.Drive();

class vehicle
{
    private string engine;

    public vehicle(string engine)
    {
        this.engine = engine;
    }

    public void StartEngine()
    {
        Console.WriteLine($"Starting {this.engine} engine.");
    }
}

class Car
{
    private vehicle vehicle;

    public Car(string engineType)
    {
        this.vehicle = new vehicle(engineType);
    }

    public void Drive()
    {
        this.vehicle.StartEngine();
        Console.WriteLine("Driving the car.");
    }
}