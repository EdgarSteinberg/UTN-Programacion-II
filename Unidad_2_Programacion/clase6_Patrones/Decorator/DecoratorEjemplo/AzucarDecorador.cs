namespace EstructurasLibrary;

public class AzucarDecorador : AgregadoDecorado
{
    public AzucarDecorador(BebidaDecorador bebida) : base(bebida)
    {
    }

    public override double GetCosto()
    {
        return base.GetCosto() + 1;
    }

    public override string GetDescripcion()
    {
        return base.GetDescripcion() + " Azucar";
    }
}