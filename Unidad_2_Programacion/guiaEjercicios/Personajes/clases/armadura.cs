namespace clases
{
    public class Armadura
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private double _puntosDeDefensa;
        public double PuntosDeDefensa
        {
            get { return _puntosDeDefensa; }
            set { _puntosDeDefensa = value; }
        }

        private double _penalizacionMovimiento;
        public double PenalizacionMovimiento
        {
            get { return _penalizacionMovimiento; }
            set { _penalizacionMovimiento = value; }
        }

        private TipoAtaque _tipoDeProteccion;

        public TipoAtaque TipoDeProteccion
        {
            get { return _tipoDeProteccion; }
            set { _tipoDeProteccion = value; }
        }
    }
}