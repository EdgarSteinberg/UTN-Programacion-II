using System;

// -------------------------------
// Clase base
// -------------------------------
public abstract class Navio
{
    public virtual string MostrarInformacion()
    {
        return $"Nombre: {this.Nombre} - Flotabilidad: {this.Flotabilidad} - Solidez: {this.Solidez} - Estabilidad: {this.Estabilidad} - Velocidad Crucero: {this.VelocidadCrucero}";
    }

    public float Flotabilidad { get; set; }
    public float Solidez { get; set; }
    public float Estabilidad { get; set; }
    public float VelocidadCrucero { get; set; }
    public string Nombre { get; set; }

    public Navio(float flotabilidad, float solidez, float estabilidad, float velocidadCrucero, string nombre)
    {
        this.Flotabilidad = flotabilidad;
        this.Solidez = solidez;
        this.Estabilidad = estabilidad;
        this.VelocidadCrucero = velocidadCrucero;
        this.Nombre = nombre;
    }
}

// -------------------------------
// Acorazado
// -------------------------------
public class Acorazado : Navio
{
    public float Blindaje { get; set; }
    public float PotenciaFuego { get; set; }

    public Acorazado(float flotabilidad, float solidez, float estabilidad, float velocidadCrucero, string nombre,
                     float blindaje, float potenciaFuego)
        : base(flotabilidad, solidez, estabilidad, velocidadCrucero, nombre)
    {
        this.Blindaje = blindaje;
        this.PotenciaFuego = potenciaFuego;
    }

    public override string MostrarInformacion()
    {
        return base.MostrarInformacion() + $" - Blindaje: {this.Blindaje} - Potencia de Fuego: {this.PotenciaFuego}";
    }
}

// -------------------------------
// Destructor
// -------------------------------
public class Destructor : Navio
{
    public float PotenciaFuego { get; set; }
    public float Maniobrabilidad { get; set; }
    public float VelocidadMaxima { get; set; }

    public Destructor(float flotabilidad, float solidez, float estabilidad, float velocidadCrucero, string nombre,
                      float potenciaFuego, float maniobrabilidad, float velocidadMaxima)
        : base(flotabilidad, solidez, estabilidad, velocidadCrucero, nombre)
    {
        this.PotenciaFuego = potenciaFuego;
        this.Maniobrabilidad = maniobrabilidad;
        this.VelocidadMaxima = velocidadMaxima;
    }

    public override string MostrarInformacion()
    {
        return base.MostrarInformacion() + $" - Potencia de Fuego: {this.PotenciaFuego} - Maniobrabilidad: {this.Maniobrabilidad} - Velocidad Máxima: {this.VelocidadMaxima}";
    }
}

// -------------------------------
// Barco Hospital
// -------------------------------
public class BarcoHospital : Navio
{
    public int CapacidadPacientes { get; set; }

    public BarcoHospital(float flotabilidad, float solidez, float estabilidad, float velocidadCrucero, string nombre,
                         int capacidadPacientes)
        : base(flotabilidad, solidez, estabilidad, velocidadCrucero, nombre)
    {
        this.CapacidadPacientes = capacidadPacientes;
    }

    public override string MostrarInformacion()
    {
        return base.MostrarInformacion() + $" - Capacidad Pacientes: {this.CapacidadPacientes}";
    }
}

// -------------------------------
// Lancha Médica
// -------------------------------
public class LanchaMedica : Navio
{
    public bool MotorFueraBorda { get; set; }
    public int CapacidadGrua { get; set; }

    public LanchaMedica(float flotabilidad, float solidez, float estabilidad, float velocidadCrucero, string nombre,
                        bool motorFueraBorda, int capacidadGrua)
        : base(flotabilidad, solidez, estabilidad, velocidadCrucero, nombre)
    {
        this.MotorFueraBorda = motorFueraBorda;
        this.CapacidadGrua = capacidadGrua;
    }

    public override string MostrarInformacion()
    {
        return base.MostrarInformacion() + $" - Motor Fuera de Borda: {this.MotorFueraBorda} - Capacidad Grúa: {this.CapacidadGrua}";
    }
}

// -------------------------------
// Programa principal
// -------------------------------
class Program
{
    static void Main()
    {
        Acorazado a = new Acorazado(80, 90, 85, 30, "Titan", 100, 120);
        Console.WriteLine(a.MostrarInformacion());

        Destructor d = new Destructor(70, 75, 80, 40, "Rayo", 110, 95, 60);
        Console.WriteLine(d.MostrarInformacion());

        BarcoHospital h = new BarcoHospital(95, 85, 100, 20, "Sibelancia", 75);
        Console.WriteLine(h.MostrarInformacion());

        LanchaMedica l1 = new LanchaMedica(90, 60, 50, 70, "La Gaucha", true, 300);
        Console.WriteLine(l1.MostrarInformacion());

        LanchaMedica l2 = new LanchaMedica(90, 60, 50, 70, "El Gaucho", true, 300);
        Console.WriteLine(l2.MostrarInformacion());
    }
}