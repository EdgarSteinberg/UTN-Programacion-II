namespace clases
{
    public class Habilidad
    {
        private string _nombre = "";
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

        private int _puntosDeEfecto;
        public int PuntosDeEfecto
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

        private bool _desbloqueada;
        public bool Desbloqueada
        {
            get { return _desbloqueada; }
            set { _desbloqueada = value; }
        }

        public Habilidad(string nombre, int nivelRequerido, int puntoDeEfecto, TipoHabilidad tipo)
        {
            Nombre = nombre;
            NivelRequerido = nivelRequerido;
            PuntosDeEfecto = puntoDeEfecto;
            Tipo = tipo;
            Desbloqueada = false;
        }
    }
}