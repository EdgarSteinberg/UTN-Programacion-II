public class Cafe : Bebida
{
    public Cafe()
    {
        Descripcion = "Café";
    }
    public override double Costo()
    {
        return 10.0;
    }
}