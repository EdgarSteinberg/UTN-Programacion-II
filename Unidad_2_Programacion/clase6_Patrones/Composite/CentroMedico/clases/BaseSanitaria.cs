namespace EstructurasLibrary;

/* Component
La clase abstracta común: */

public abstract class BaseSanitaria
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }

    protected BaseSanitaria(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
    }

    public string ObtenerDireccion()
    {
        return Direccion;
    }

    public abstract int ObtenerCantidadAmbulancias();

    public abstract double ObtenerTiempoMedioAsistencia();
}