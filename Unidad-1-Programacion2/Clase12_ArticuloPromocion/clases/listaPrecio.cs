namespace clases
{
    public class ListaPrecio
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private DateTime _vigencia;

        public DateTime Vigencia
        {
            get { return _vigencia; }
            set { _vigencia = value; }
        }

        private List<Articulo> _articulos = new List<Articulo>();

        public List<Articulo> Articulos
        {
            get { return _articulos; }
            set { _articulos = value; }
        }

        public void Imprimir()
        {
            Console.WriteLine($"Lista: {Nombre} - Vigencia: {Vigencia}");

            foreach (var articulo in Articulos)
            {
                Console.WriteLine($"{articulo.Nombre} - {articulo.ObtenerPrecio()}");
            }
        }
        public ListaPrecio(string nombre, DateTime vigencia)
        {
            _nombre = nombre;
            Vigencia = vigencia;
        }

    }
}