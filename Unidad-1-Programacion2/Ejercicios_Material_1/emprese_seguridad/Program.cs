using System;

namespace DronesSeguridad
{
    // -------------------------------
    // Clase abstracta base Herramienta
    // -------------------------------
    public abstract class Herramienta
    {
        // Peso de la herramienta
        private int _peso = 0;

        public int Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }
    }

    // -------------------------------
    // Herramientas concretas
    // -------------------------------
    public class SensorInfrarrojo : Herramienta
    {
        public SensorInfrarrojo()
        {
            this.Peso = 250;
        }
    }

    public class Taser : Herramienta
    {
        public Taser()
        {
            this.Peso = 300;
        }
    }

    public class BrazoRobotico : Herramienta
    {
        public BrazoRobotico()
        {
            this.Peso = 500;
        }
    }

    // -------------------------------
    // Clase Drone
    // -------------------------------
    public class Drone
    {
        // Valores base
        private float _velocidadBase = 5;
        private float _alturaBase = 100;

        // Velocidad y altura actuales
        private float _velocidad;
        private float _altura;

        public float Velocidad
        {
            get { return _velocidad; }
            set { _velocidad = value; }
        }

        public float Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        // Herramienta que lleva el drone
        private Herramienta _herramienta;

        public Herramienta HerramientaActual
        {
            get { return _herramienta; }
            set { _herramienta = value; }
        }

        // Constructor con herramienta
        public Drone(Herramienta h)
        {
            // Inicializa velocidad y altura base
            this._velocidad = _velocidadBase;
            this._altura = _alturaBase;

            // Aplica penalización según la herramienta
            Penalizaciones(h);
        }

        // Método para aplicar penalizaciones según peso de herramienta
        public void Penalizaciones(Herramienta h)
        {
            this.HerramientaActual = h;

            // Resetear a valores base antes de aplicar penalización
            this.Velocidad = _velocidadBase;
            this.Altura = _alturaBase;

            int limite = 200; // Peso máximo sin penalización

            if (h.Peso > limite)
            {
                int exceso = h.Peso - limite; // Cuánto pesa de más
                int tramos = exceso / 50;     // Cada 50g es un tramo de penalización

                // Reducir velocidad 2% por tramo
                this.Velocidad -= this.Velocidad * (0.02f * tramos);

                // Reducir altura 5% por tramo
                this.Altura -= this.Altura * (0.05f * tramos);
            }
        }

        // Método para mostrar información del drone
        public string MostrarInformacion()
        {
            return $"Velocidad: {this.Velocidad:F2} m/s - Altura: {this.Altura:F2} m - Herramienta: {this.HerramientaActual.GetType().Name}";
        }
    }

    // -------------------------------
    // Clase principal
    // -------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos drones con distintas herramientas
            Drone drone1 = new Drone(new SensorInfrarrojo());
            Console.WriteLine(drone1.MostrarInformacion());

            Drone drone2 = new Drone(new Taser());
            Console.WriteLine(drone2.MostrarInformacion());

            Drone drone3 = new Drone(new BrazoRobotico());
            Console.WriteLine(drone3.MostrarInformacion());
        }
    }
}