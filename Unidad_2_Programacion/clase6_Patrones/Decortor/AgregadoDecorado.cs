public class AgregadoDecorado : Bebida
{
    private Bebida _bebida;
    public AgregadoDecorado(Bebida bebida)
    {
        _bebida = bebida;
    }
    
    public override  double Costo()
    {
        return _bebida.Costo();
    }
    

}