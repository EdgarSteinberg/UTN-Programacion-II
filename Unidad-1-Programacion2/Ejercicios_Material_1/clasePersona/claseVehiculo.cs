/* Crear una clase Vehiculo que tenga los atributos públicos marca, modelo y un atributo privado
patente.
● Crear una instancia y asignarle valores; notar que el atributo privado no está disponible
para la asignación de valores.
● Mostrar por pantalla los valores asignados. */



/* Vehiculo objVehiculo = new Vehiculo();

objVehiculo.Marca = "MercedezBenz";
objVehiculo.Modelo = "Clase E 4 matic";
objVehiculo.SetPatente = "822";

objVehiculo.MostrarInfo();

Console.WriteLine($"Marca: {objVehiculo.Marca}, Modelo: {objVehiculo.Modelo}"); */

class Vehiculo
{
    public string Marca { get; set; }= "";
    public string Modelo { get; set; }= "";
    private string Patente { get; set; } = "";

    // Método para mostrar toda la info (incluyendo la privada)
    public void MostrarInfo()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Patente: {Patente}");
    }

    // Método para asignar la patente desde la clase
    public void SetPatente(string patente)
    {
        Patente = patente;
    }
}