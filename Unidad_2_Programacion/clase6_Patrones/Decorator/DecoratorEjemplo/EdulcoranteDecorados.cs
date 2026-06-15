namespace EstructurasLibrary;

public class Edulcorante : AgregadoDecorado
{
    public Edulcorante(BebidaDecorador bebida) : base(bebida)
    {
    }

    public override double GetCosto()
    {
        return base.GetCosto() + 1;
    }

    public override string GetDescripcion()
    {
        return base.GetDescripcion() + "Edulcorante";
    }
}