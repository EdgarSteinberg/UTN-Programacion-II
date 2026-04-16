namespace Ejercicios.clases;


public class Obsecuente : Persona
{
    public Obsecuente(Persona jefe)
    {
        Jefe = jefe;
    }
    public override bool AceptaSubir(Micro micro)
    {
        return Jefe.AceptaSubir(micro);
    }
} 