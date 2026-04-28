void OperateDevice(ITurnable device)
{
    device.TurnOn();
}

AirCorditioner ac = new AirCorditioner();
Engine engine = new Engine();
OperateDevice(ac);
OperateDevice(engine);

interface ITurnable
{
    bool TurnOn();
    bool TurnOff();
}

class AirCorditioner : ITurnable
{
    public bool TurnOn()
    {
        Console.WriteLine("AC Encendido");
        return true;
    }

    public bool TurnOff()
    {
        Console.WriteLine("AC Apagado");
        return true;
    }
}

class Engine : ITurnable
{
       public bool TurnOn()
    {
        Console.WriteLine("AC Encendido");
        return true;
    }

    public bool TurnOff()
    {
        Console.WriteLine("AC Apagado");
        return true;
    }
}