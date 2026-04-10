/* Console.WriteLine("Ingrese su edad!");

int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Su edad es {edad}"); */

/* int edad = 0;

Console.WriteLine("Ingrese su edad!");
try
{
    edad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Su edad es {edad}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ha ocurrido un erro no esperado. Usted es un maravillos usuario {ex.Message}");
} */



Console.WriteLine("Ingrese su edad!");
int edad = 0;
try
{
    edad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Su edad es {edad}");
    //throw new DivideByZeroException();
    double resultado = 100/ edad;
}
catch(FormatException ex)
{
    Console.WriteLine($"El formato de la edad ingresada no es correcto. Usted es un maravillos usuario {ex.Message}");
    
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Usted quiere dividir por cero y eso no se puede. 'animos!' {ex.Message}");
    
}
catch (Exception ex)
{
    Console.WriteLine($"Ha ocurrido un error no esperado. Usted es un maravillos usuario {ex.Message}");
}

