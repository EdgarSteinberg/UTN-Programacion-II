
namespace Ejercicios.clases;

public class Claustrofobico : Persona
{

    private static readonly double Volumen_Minimo = 120;
    public override bool AceptaSubir(Micro micro)
    {

        if (micro.Volumen >= Volumen_Minimo)
        {
            Console.WriteLine($"Puede ingresar al micro porque su volumen es de {micro.Volumen}");
            return true;
        }

        Console.WriteLine($"No Puede ingresar al micro porque su volumen es de {micro.Volumen}");
        return false;

    }
}