// Conjunto de numeros unicos
HashSet<Empleado> unicos = new HashSet<Empleado>();
Gerente objGerente = new Gerente();
objGerente.Legajo = 1234;
unicos.Add(objGerente);
Gerente nuevoGerente = new Gerente();
objGerente.Legajo = 1234;
unicos.Add(nuevoGerente);
unicos.Add(new Administrativo()); //Ignorado, ya existe

// Saber si existe un elemento
Console.WriteLine(unicos.Contains(objGerente));
unicos.Remove(objGerente);
//Recorrer el conjunto
foreach (Empleado unico in unicos)
{
    Console.WriteLine(unico.ToString());
}







/* using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

BonoPresentismo bonoA = new BonoPresentismoA();
BonoPresentismo bonoB = new BonoPresentismoB();
BonoResultado bonoResultado = new BonoResultado();

Empleado empleado = new Gerente();
empleado.Inasistencias = 1;
empleado.ObjetivoCumplido = 100;
empleado.BonoPresentismo = bonoA;
empleado.BonoResultado = bonoResultado;

Administrativo admin = new Administrativo();
admin.Inasistencias = 0;
admin.ObjetivoCumplido = 80;
admin.BonoPresentismo = bonoA;
admin.BonoResultado = bonoResultado;
 */

/* Dictionary */
/* Dictionary<int,Empleado> dicEmpleados = new Dictionary<int, Empleado>();
dicEmpleados.Add(121212, empleado);
dicEmpleados.Add(101010, admin);

foreach (KeyValuePair<int, Empleado> item in dicEmpleados)
{
    Console.WriteLine($"El empleado con legajo {item.Key} tiene un sueldo de ${item.Value.CalcularSueldo()}");
}

if(dicEmpleados.ContainsKey(121212))
{
    Console.WriteLine($"El empleado con legajo 121212 tiene un sueldo de ${dicEmpleados[121212].CalcularSueldo()}");
}
else
{
    Console.WriteLine("No se enocntro el empleado con legajo 121212");
}
if(dicEmpleados.ContainsKey(101010))
{
    Console.WriteLine($"El empleado con legajo 101010 tiene un sueldo de ${dicEmpleados[101010].CalcularSueldo()}");
}
else
{
    Console.WriteLine("No se enocntro el empleado con legajo 101010");
} */


//Console.WriteLine();
//Console.WriteLine($"El empleado tiene sueldo de ${empleado.CalcularSueldo()}");

//empleado.BonoPresentismo = bonoB;
//Console.WriteLine($"El empleado tiene sueldo de ${empleado.CalcularSueldo()}");

//Empresa objEmpresa = new Empresa();
//objEmpresa.Empleados = new List<Empleado>();
//objEmpresa.Empleados.Add(empleado);
//objEmpresa.Empleados.Add(admin);

//objEmpresa.InformarSueldos();

//Console.WriteLine("Ahora quitamos el empleado con indice 1");
//objEmpresa.Empleados.RemoveAt(1); //Elimina el indice que le pasamos por parametro en la coleccion

/* if (objEmpresa.Empleados.Contains(empleado))
{
    Console.WriteLine("El empleado sigue en la empresa");
}
else
{
    Console.WriteLine("El empleado ya no esta en la empresa");
}

objEmpresa.Empleados.Remove(empleado);

Empleado objEmpleado = objEmpresa.Empleados.ElementAt(0);
Console.WriteLine($"Calculando sueldo {objEmpleado.CalcularSueldo()}");


if (objEmpresa.Empleados.Contains(empleado))
{
    Console.WriteLine("El empleado sigue en la empresa");
}
else
{
    Console.WriteLine("El empleado ya no esta en la empresa");
}

objEmpresa.InformarSueldos(); */

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

public class Empresa
{
    private List<Empleado> _empleados;

    public List<Empleado> Empleados
    {
        get { return _empleados; }
        set { _empleados = value; }
    }

    public Empresa()
    {
        _empleados = new List<Empleado>();
    }

    public void InformarSueldos()
    {
        foreach (Empleado item in Empleados)
        {
            Console.WriteLine($"El sueldo empleado es: {item.CalcularSueldo()} ({item})");
        }
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

    public int legajo;
    public int Legajo {get; set; }
    public override bool Equals(object? obj)
    {
        if (obj is Gerente gerente && gerente.Legajo == this.Legajo)
        {
            return true;
        }
        else
        {
            return false;
        }
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