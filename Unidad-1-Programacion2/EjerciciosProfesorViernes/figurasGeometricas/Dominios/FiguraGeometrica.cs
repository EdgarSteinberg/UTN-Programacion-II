namespace figurasGeometricas.Dominio;


public abstract class FiguraGeometrica
{
    private string nombre;
    private string color;
    public FiguraGeometrica(string nombre, string color)
    {
        this.nombre = nombre;
        this.color = color;
    }

    public string Nombre
    {
        get { return nombre; }
    }

    public string Color
    {
        get { return color; }
    }
    public abstract float CalcularArea();
    public abstract float CalcularPerimetro();
}