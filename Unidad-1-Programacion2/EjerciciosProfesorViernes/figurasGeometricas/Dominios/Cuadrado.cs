namespace figurasGeometricas.Dominio;

public class Cuadrado : FiguraGeometrica
{
    private float lado;

    public Cuadrado(string nombre, string color, float lado) : base(nombre, color)
    {
        this.lado = lado;
    }

    public override float CalcularArea()
    {
        return lado * lado;
    }

    public override float CalcularPerimetro()
    {
        return lado * 4;
    }
}