namespace clases
{
    public class Promocion : Articulo
    {
        private List<PromocionProducto> _promociones = new List<PromocionProducto>();

        public List<PromocionProducto> Promociones
        {
            get { return _promociones; }
            set { _promociones = value; }
        }

        public override double ObtenerPrecio()
        {
            double total = 0;

            foreach (var item in Promociones)
            {
                double precioBase = item.Producto.ObtenerPrecio();
                double precioModificado = precioBase * (1 + item.Porcentaje);

                total += precioModificado * item.Cantidad;
            }

            return total;
        }
    }
}