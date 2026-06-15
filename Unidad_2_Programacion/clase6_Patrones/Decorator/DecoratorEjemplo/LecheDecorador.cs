namespace EstructurasLibrary;


public class LecheDecorator : AgregadoDecorado
{
    public LecheDecorator(BebidaDecorador bebida) : base(bebida)
    {
    }

    public override double GetCosto()
    {
        return base.GetCosto() + 2;
    }

    public override string GetDescripcion()
    {
        return base.GetDescripcion() + " Leche";
    }
}