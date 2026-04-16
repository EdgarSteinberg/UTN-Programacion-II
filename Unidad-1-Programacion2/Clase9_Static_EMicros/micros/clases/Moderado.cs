namespace Ejercicios.clases;

public class Moderado : Persona
{
    private int _minimoLugar;
    public int MinimoLugar
    {
        get { return _minimoLugar; }
        set { _minimoLugar = value; }
    }
    public Moderado(int cantidaMinima)
    {
        MinimoLugar = cantidaMinima;
    }

    public override bool AceptaSubir(Micro micro)
    {
        if (micro.LugaresLibres() >= MinimoLugar)
        {
            Console.WriteLine($"El Moderado acepta subir");
            return true;
        }
        else
        {
            Console.WriteLine($"El Moderado no acepta subir");

            return true;
        }
    }
}