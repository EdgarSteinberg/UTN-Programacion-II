namespace celulares.Dominio;

public class MotorolaG5 : Celular
{
    public override void Llamada(int duracion)
    {
        Bateria -= duracion * 0.25f;

        if (Bateria < 0)
        {
            Bateria = 0;
        }
    }
}