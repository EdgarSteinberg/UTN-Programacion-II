using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

BonoPresentismo bonoA = new BonoPresentismoA();
BonoPresentismo bonoB = new BonoPresentismoB();
BonoResultado bonoResultado = new BonoResultado();

Empleado empleado = new Gerente();
empleado.Inasistencias = 1;
empleado.ObjetivoCumplido = 100;
empleado.BonoPresentismo = bonoA;
empleado.BonoResultado = bonoResultado;

Gerente gerente = (Gerente) empleado;
gerente.Print();

Console.WriteLine($"El empleado tiene sueldo de ${empleado.CalcularSueldo()}");

empleado.BonoPresentismo = bonoB;
Console.WriteLine($"El empleado tiene sueldo de ${empleado.CalcularSueldo()}");

List<Empleado> empleados = new List<Empleado>();
empleados.Add(admin);
empleados.Add(empleado);
/* empleado.Remove(admin); */

foreach(Empleado item in empleados)
{
    Console.WriteLine($"El sueldo del empledo es: {item.CalcularSueldo()} ({item.ToString()})");
}

public abstract class Empleado
{
    public int Inasistencias { get; set; }

    public float ObjetivoCumplido { get; set; }

    public BonoPresentismo BonoPresentismo { get; set; }

    public BonoResultado BonoResultado { get; set; }

    public abstract float CalcularNeto();

    public float CalcularSueldo()
    {
        return this.CalcularNeto() + this.BonoPresentismo.Calcular(this.Inasistencias) + BonoResultado.Calcular(this.ObjetivoCumplido, this.CalcularNeto());
    }


}

public class Gerente : Empleado, Imprimible
{
    public override float CalcularNeto()
    {
        return 100000;
    }

    public string Print()
    {
        return "Soy un gerente";
    }

    public override string ToString()
    {
        return "Gerente";
    }
}

public class Administrativo : Empleado
{
    public override float CalcularNeto()
    {
        return 500000;
    }

    public override string ToString()
    {
        return "Administrativo";
    }
}

public abstract class BonoPresentismo
{
    public abstract float Calcular(int inasistencias);


}

public class BonoPresentismoA : BonoPresentismo
{
    public override float Calcular(int inasistencias)
    {
        if (inasistencias == 0)
            return 1000;
        else if (inasistencias == 1)
            return 450;
        else
            return 0;
    }
}


public class BonoPresentismoB : BonoPresentismo
{
    public override float Calcular(int inasistencias)
    {
        return 500;
    }
}

public class BonoResultado
{
    public float Calcular(float ObjetivoCumplido, float neto)
    {
        if (ObjetivoCumplido == 100)
            return 0.1F * neto;
        else if (ObjetivoCumplido >= 80)
            return 800;
        else
            return 0;

    }


}

public interface Imprimible
{
    public string Print();
}

public class Printer
{
    public void Print(Imprimible imprimible)
    {
        Console.WriteLine(imprimible.Print());
    }


}