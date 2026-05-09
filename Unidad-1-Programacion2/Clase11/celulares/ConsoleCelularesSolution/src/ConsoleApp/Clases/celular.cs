namespace Clases
{
    public abstract class Celular
    {

        public Celular()
        {
            _bateria = new Bateria(); // Instancio la Bateria
        }
        public abstract void PerdidaBateria(int duracion);
        public void Recargar()
        {
            this.Bateria.Recargar();
        }
        public double PuntosDeBateria()
        {
            return _bateria.PuntosDeBateria;
        }

        public void Llamar(Celular destino, int duracion)
        {
            this.PerdidaBateria(duracion);
            destino.PerdidaBateria(duracion);
        }
        private Bateria _bateria;
        public Bateria Bateria
        {
            get { return _bateria; }
            set { _bateria = value; }
        }

        public bool EstaApagado()
        {
            if (_bateria.PuntosDeBateria == 0)
            {
                return true;
            }
            return false;
        }

    }



}
