

using figurasGeometricas.Dominio;

List<FiguraGeometrica> figuras = new List<FiguraGeometrica>();

figuras.Add(new Cuadrado("Cuadrado", "Rojo", 5));
figuras.Add(new Circulo("Circulo", "Azul", 3));
figuras.Add(new Triangulo("Triángulo", "Verde", 4,4,4,3));


foreach(FiguraGeometrica figura in figuras)
{
    Console.WriteLine(figura.Nombre);
    Console.WriteLine(figura.Color);
    Console.WriteLine(figura.CalcularArea());
    Console.WriteLine(figura.CalcularPerimetro());
}