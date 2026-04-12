namespace Clase8_Exepciones_Micros.clases;


//los obsecuentes toman la misma decisión que tomaría su jefe (de cada empleado se sabe quién es su
//jefe, que es otro empleado)
public class Obsecuentes : Persona
{

    public override bool AceptaSubir(Micro micro)
    {
        return Jefe != null && Jefe.AceptaSubir(micro);
    }

}