namespace EstructurasLibrary;

public class CafeDecorador : BebidaDecorador
{
    public override double GetCosto()
    {
        return 10;
    }

    public override string GetDescripcion()
    {
        return"Cafe";
    }
}