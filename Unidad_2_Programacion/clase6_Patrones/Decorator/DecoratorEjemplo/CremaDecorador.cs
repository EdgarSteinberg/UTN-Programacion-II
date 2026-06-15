namespace EstructurasLibrary;


public class CreamaDecorador : AgregadoDecorado
{
    public CreamaDecorador(BebidaDecorador bebida) : base(bebida)
    {
    }

    public override double GetCosto()
    {
        return base.GetCosto() + 3;
    }

    public override string GetDescripcion()
    {
        return base.GetDescripcion() + "Crema";
    }
}