public class Azucar : AgregadoDecorado
{
    public Azucar(Bebida bebida) : base(bebida)
    {
        Descripcion = bebida.Descripcion + ", Azúcar";
    }
    
    public override double Costo()
    {
        return base.Costo() + 0.5;
    }
}