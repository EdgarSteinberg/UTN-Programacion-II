namespace Clase8_Exepciones_Micros.clases;

//los moderados se suben sólo si quedan al menos x lugares libres (no importa si sentados o parados),
//donde el x es particular de cada persona moderada.

public class Moderados : Persona
{
    private int _minimoLugar;

    public int MinimoLugar
    {
        get { return _minimoLugar; }
        set { _minimoLugar = value; }
    }
    public override bool AceptaSubir(Micro micro)
    {
        return micro.LugaresLibres() > MinimoLugar;
    }
}