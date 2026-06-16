/* using EstructurasLibrary;

class Program
{
    static void Main()
    {
        ConversorUTM conversor = new ConversorUTM();
        CentroMonitoreo centro = new CentroMonitoreo(conversor);


        var gps1 = new ModuloGPS("GPS");
        var gps2 = new ModuloGPS("GPS");

        centro.AgregarModulo(gps1);
        centro.AgregarModulo(gps2);

        centro.SeguimientoVehiculo();
    }
}


/* “El sistema delega la transformación de coordenadas a una estrategia intercambiable, permitiendo extensibilidad sin modificar el módulo GPS ni el centro de monitoreo.” */