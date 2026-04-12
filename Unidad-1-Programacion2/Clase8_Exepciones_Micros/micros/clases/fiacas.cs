namespace Clase8_Exepciones_Micros.clases;

//los fiacas se suben sólo si entran sentados
public class Fiaca : Persona
{
    public override bool AceptaSubir(Micro micro)
    {
        return micro.CantidadAsientos() > 0;
    }
}