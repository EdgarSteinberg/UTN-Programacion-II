

using clases;

Producto coca = new Producto("Coca-Cola","123", 100);
Producto papas = new Producto("Leys","223", 150);

Console.WriteLine($"Precio de la gaseosa Coca-Cola: ${coca.ObtenerPrecio()}");
Console.WriteLine($"Precio de las papas: ${papas.ObtenerPrecio()}");


PromocionProducto item1 = new PromocionProducto(coca, 5, -0.1);
PromocionProducto item2 = new PromocionProducto(papas, 7, -0.3);
 

Promocion promo1 = new Promocion();
promo1.Nombre = "Promo Combo";

promo1.Promociones.Add(item1);
promo1.Promociones.Add(item2);

ListaPrecio lista = new ListaPrecio("Lista Mayo",DateTime.Now);
 
lista.Articulos.Add(coca);
lista.Articulos.Add(papas);
lista.Articulos.Add(promo1);

lista.Imprimir();