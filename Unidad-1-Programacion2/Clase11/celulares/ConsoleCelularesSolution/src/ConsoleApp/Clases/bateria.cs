namespace Clases
{
    public class Bateria
    {
        public readonly double puntosMaximoDeCarga = 5;
        private double _puntosDeBateria;
        public double PuntosDeBateria
        {
            get { return _puntosDeBateria; }
            set { _puntosDeBateria = value; }
        }

        public Bateria()
        {
            this.Recargar();
        }

        public void Recargar()
        {
            PuntosDeBateria = puntosMaximoDeCarga;
        }
    }
}
