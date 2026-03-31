namespace figurasGeometricas.Dominio;


public class Circulo : FiguraGeometrica
{
    private float radio;

    public Circulo(string nombre, string color, float radio) : base(nombre, color)
    {
        this.radio = radio;
    }

    public override float CalcularArea()
    {
        return 3.14f * radio * radio;
    }

    public override float CalcularPerimetro()
    {
        return 2 * 3.14f * radio;
    }
}