namespace clases
{
    public class Armadura
    {
        private string _nombre = "";
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _puntosDeDefensa;
        public int PuntosDeDefensa
        {
            get { return _puntosDeDefensa; }
            set { _puntosDeDefensa = value; }
        }

        private int _penalizacionMovimiento;
        public int PenalizacionMovimiento
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

        public Armadura(string nombre, int puntosDeDefensa, int penalizacionMovimiento, TipoAtaque tipoDeProteccion)
        {
            Nombre = nombre;
            PuntosDeDefensa = puntosDeDefensa;
            PenalizacionMovimiento = penalizacionMovimiento;
            TipoDeProteccion = tipoDeProteccion;
        }
    }
}