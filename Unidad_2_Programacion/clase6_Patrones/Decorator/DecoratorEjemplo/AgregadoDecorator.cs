namespace EstructurasLibrary;

public class AgregadoDecorado : BebidaDecorador
{
    private BebidaDecorador _bebida;

    public AgregadoDecorado(BebidaDecorador bebida)
    {
        _bebida = bebida;
    }
    public override double GetCosto()
    {
        return _bebida.GetCosto();
    }

    public override string GetDescripcion()
    {
        return _bebida.GetDescripcion();
    }
}