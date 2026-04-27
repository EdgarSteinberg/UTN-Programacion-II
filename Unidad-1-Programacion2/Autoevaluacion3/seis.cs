//Si la línea `Console.WriteLine((SmartDevice) dev).GetStatus());` fuera agregada dentro de `CheckDevice`, y se llamara a `CheckDevice(genericDev)`, ¿qué resultado se obtendría en la consola?
void CheckDevice(Device dev)
{
    Console.WriteLine(dev.GetId());
}


Device genericDev = new Device();
Device smartDev = new SmartDevice();
CheckDevice(genericDev);
CheckDevice(smartDev);

class Device
{
    public virtual string GetId()
    {
        return "Generic Device";
    }
}

class SmartDevice : Device
{
    public override string GetId()
    {
        return "Smart Device";
    }

    public string GetStatus()
    {
        return "Online";
    }
}