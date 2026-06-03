using EstructurasLibrary;

class Program
{
    static void Main(string[] args)
    {
        // Crear aplicación
        Aplicacion app = new Aplicacion();

        // Establecer hora local
        app.EstablecerFecha(DateTime.Now);

        // Crear destinos (nombre + diferencia horaria)
        var brasil = new Destino("Brasil", 2);
        var newYork = new Destino("New York", -1);
        var beijing = new Destino("Beijing", 11);

        // Agregar destinos a la aplicación
        app.AgregarDestino(brasil);
        app.AgregarDestino(newYork);
        app.AgregarDestino(beijing);

        // Mostrar horas sincronizadas
        app.MostrarHoras();
    }
}