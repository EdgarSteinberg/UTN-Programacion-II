namespace Clase8_Exepciones_Micros.clases;

//los apurados se suben siempre

public class Apurados : Persona
{
    public override bool AceptaSubir(Micro micro)
    {
        return true;
    }
}