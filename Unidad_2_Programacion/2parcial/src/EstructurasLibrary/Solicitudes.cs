namespace EstructurasLibrary;


    public class Solicitud
{
    public string Categoria { get; set; }
    public int Complejidad { get; set; }

    public Solicitud(string categoria, int complejidad)
    {
        Categoria = categoria;
        Complejidad = complejidad;
    }
}
