namespace Ejercicios.clases;

public class ArbolGenialogico
{
    public Persona? Raiz { get; set; }

    public void Mostrar()
    {
        Mostrar(Raiz);
    }

    private void Mostrar(Persona p)
    {
        if (p == null) return;

        Console.WriteLine($"{p.Nombre} {p.Apellido} {p.Anio_nacimiento} - {p.Id()}");

        foreach (var hijo in p.Hijos)
        {
            Mostrar(hijo);
        }
    }
}