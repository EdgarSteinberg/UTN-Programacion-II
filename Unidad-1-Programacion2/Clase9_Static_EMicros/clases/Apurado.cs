namespace Ejercicios.clases;


public class Apurado : Persona
{
    public override bool AceptaSubir(Micro micro)
    {
        if (micro.HayLugar())
        {
            Console.WriteLine($"Puede ingresar al micro porque hay lugar");
            return true;
        }
        else
        {
            Console.WriteLine($"No Puede ingresar al micro porque noa hay lugar");
            return true;
        }
    }
}