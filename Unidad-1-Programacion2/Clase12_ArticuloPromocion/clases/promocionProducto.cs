namespace clases
{
    public class PromocionProducto
    {
        private Producto _producto;

        public Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }


        private int _cantidad;
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private double _porcentaje;
        public double Porcentaje
        {
            get { return _porcentaje; }
            set { _porcentaje = value; }
        }

        public PromocionProducto(Producto producto, int cantidad, double porcentaje)
        {

            _producto = producto;
            Cantidad = cantidad;
            Porcentaje = porcentaje;

        }

    }
}