namespace Clase8_Exepciones_Micros.clases;

//los claustrofóbicos se suben sólo si el micro tiene más de 120 m3 de volumen (se sabe el volumen de
//cada micro)
public class Claustofobicos : Persona
{
    public override bool AceptaSubir(Micro micro)
    {
        return micro.Volumen > 130;
    }
}