namespace celulares.Dominio;

public class Iphone : Celular
{
    public override void Llamada(int duracion)
    {
        Bateria -= 0.1f;

        if (Bateria < 0)
        {
            Bateria = 0;
        }
    }
}