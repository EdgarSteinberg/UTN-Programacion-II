namespace EstructurasLibrary;

public class Te : BebidaDecorador
{
    public override double GetCosto()
    {
        return 5;
    }

    public override string GetDescripcion()
    {
        return "Té";
    }
}