namespace figurasGeometricas.Dominio;


public class Triangulo : FiguraGeometrica
{
    private float lado1;
    private float lado2;

    private float lado3;

    private float altura;


    public Triangulo(string nombre, string color, float lado1, float lado2, float lado3, float altura) : base(nombre, color)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
        this.altura = altura;
    }

    public override float CalcularArea()
    {
        return lado1 * altura / 2;
    }

    public override float CalcularPerimetro()
    {
        return lado1 + lado2 + lado3;
    }
}