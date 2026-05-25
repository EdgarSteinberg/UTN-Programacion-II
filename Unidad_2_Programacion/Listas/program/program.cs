using EstructurasLibrary;

Pedido pedido1 = new Pedido(1, 1, "CPU");
Pedido pedido2 = new Pedido(2, 1, "CPU");
Pedido pedido3 = new Pedido(3, 2, "CPU");
Pedido pedido4 = new Pedido(4, 1, "CPU");
Pedido pedido5 = new Pedido(5, 2, "CPU");

Pedido pedido6 = new Pedido(6, 1, "E/S");
Pedido pedido7 = new Pedido(7, 2, "E/S");
Pedido pedido8 = new Pedido(8, 2, "E/S");

Balanceador balanceador = new Balanceador(5);

balanceador.RecibirPedido(pedido1);
balanceador.RecibirPedido(pedido2);
balanceador.RecibirPedido(pedido3);
balanceador.RecibirPedido(pedido4);
balanceador.RecibirPedido(pedido5);

balanceador.RecibirPedido(pedido6);
balanceador.RecibirPedido(pedido7);
balanceador.RecibirPedido(pedido8);

balanceador.MostrarServidores();