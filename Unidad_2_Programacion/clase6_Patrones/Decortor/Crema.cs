public class Crema : AgregadoDecorado
{
    public Crema(Bebida bebida) : base(bebida)
    {
        Descripcion = bebida.Descripcion + ", Crema";
    }
    
    public override double Costo()
    {
        return base.Costo() + 4.0;
    }
}