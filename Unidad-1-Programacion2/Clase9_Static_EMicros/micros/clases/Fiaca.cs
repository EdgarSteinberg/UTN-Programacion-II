namespace Ejercicios.clases;


public class Fiaca : Persona
{
    public override bool AceptaSubir(Micro micro)
    {
        if (micro.HayLugarSentado())
        {
            return true;
        }

        return false;
    }
}