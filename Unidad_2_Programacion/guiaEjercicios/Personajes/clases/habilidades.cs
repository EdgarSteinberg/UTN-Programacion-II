namespace clases
{
    public class Habilidad
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _nivelRequerido;
        public int NivelRequerido
        {
            get { return _nivelRequerido; }
            set { _nivelRequerido = value; }
        }

        private double _puntosDeEfecto;
        public double PuntosDeEfecto
        {
            get { return _puntosDeEfecto; }
            set { _puntosDeEfecto = value; }
        }

        private TipoHabilidad _tipo;
        public TipoHabilidad Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }
}