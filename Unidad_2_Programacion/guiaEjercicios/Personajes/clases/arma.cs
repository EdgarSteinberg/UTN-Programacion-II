namespace clases
{
    public class Arma 
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _danio;
        public int Danio
        {
            get { return _danio; }
            set { _danio = value; }
        }

        private TipoAtaque _tipo;
        public TipoAtaque Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

      
    }
}