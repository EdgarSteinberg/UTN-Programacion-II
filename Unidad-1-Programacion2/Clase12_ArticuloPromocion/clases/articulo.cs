namespace clases
{
    public abstract class Articulo
    {
        private string _nombre = "";
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public abstract double ObtenerPrecio();
    }
}