

Clase9 obj1 = new Clase9();
obj1.Potencia();

Calculadora obj2 = new Calculadora();

Console.WriteLine($"El resultado de 10 - 5 es: {obj2.Resta(10, 5)}");

Console.WriteLine($"El valor de PI es: {Calculadora.ValorPI}");

Console.WriteLine($"Cantidad de operaciones realizadas {Calculadora.CantidadDeOperacionesRealizadas}");

Console.WriteLine($"Operaciones");
Calculadora.Operacion operacion = Calculadora.Operacion.Suma;
Console.WriteLine($"La operacion es {operacion}");

Console.WriteLine($"Fecha");

DayOfWeek day = DayOfWeek.Tuesday;
Console.WriteLine($"El dia de la semana es {day}");

DateTime date = new DateTime(2026,4,16);
day = date.DayOfWeek;

Console.WriteLine($"El dia de hoy es {date} y dia de la semana {day}");

public class Clase9
{

    public void Potencia()
    {
        double resultado = Math.Pow(5, 2);
        Console.WriteLine($"El resultado es: {resultado}");

        int resultadoStatic = Calculadora.Suma(5, 10);
        Console.WriteLine($"El resultado de 5 + 10 es: {resultadoStatic}");
    }


}

public class Calculadora
{
    public enum Operacion
    {
        Suma,
        Resta,
        mMltiplicacion,
        Division
    }
    public static int CantidadDeOperacionesRealizadas = 0;
    //Metodo de clase Invocacion sin la necesidad de crear una Instancia
    public static int Suma(int a, int b)
    {
        CantidadDeOperacionesRealizadas++;
        return a + b;
    }

    public static readonly double ValorPI = 3.14; //constante “flexible” (se define una vez)

    public int Resta(int a, int b)
    {
        CantidadDeOperacionesRealizadas++;
        return a - b;
    }


    /*     public class Calculadora
    {
        private int a;
        private int b;

        public Calculadora(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Resta()
        {
            return a - b;
            }
        } */
}
