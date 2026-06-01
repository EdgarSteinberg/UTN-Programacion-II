public class Leche : AgregadoDecorado
{
    public Leche(Bebida bebida) : base(bebida)
    {
        Descripcion = bebida.Descripcion + ", Leche";
    }
    
    public override double Costo()
    {
        return base.Costo() + 2.0;
    }
}