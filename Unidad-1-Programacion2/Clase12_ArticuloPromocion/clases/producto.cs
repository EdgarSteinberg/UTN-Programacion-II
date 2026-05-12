namespace clases
{
    public class Producto : Articulo
    {
        private string _codigoDeBarra = "";
        public string CodigoDeBarra
        {
            get { return _codigoDeBarra; }
            set { _codigoDeBarra = value; }
        }

        private int _precio = 0;
        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public Producto(string nombre, string codigoDeBarra, int precio)
        {
            Nombre = nombre;
            CodigoDeBarra = codigoDeBarra;
            Precio = precio;
        }
        public override double ObtenerPrecio()
        {
            return Precio;
        }
    }
}