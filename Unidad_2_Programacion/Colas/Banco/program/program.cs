using EstructurasLibrary;

BancoCliente cliente1 = new BancoCliente("Edgar", "Extraccion", true, false,false);
BancoCliente cliente2= new BancoCliente("Bernardo", "Deposito", true, false,false);
BancoCliente cliente3 = new BancoCliente("Lucia", "Deposito", false, true,true);
BancoCliente cliente4 = new BancoCliente("Gonzalo", "Extaccion", false, false,false);
BancoCliente cliente5 = new BancoCliente("Julian", "Tramite", false, false,false);
BancoCliente cliente6 = new BancoCliente("Juan", "Deposito", true, false,false);
BancoCliente cliente7 = new BancoCliente("Ramona", "Extraccion", true, false,false);

BancoCaja caja1 = new BancoCaja();


caja1.AgregarCliente(cliente1);
caja1.AgregarCliente(cliente2);
caja1.AgregarCliente(cliente3);
caja1.AgregarCliente(cliente4);
caja1.AgregarCliente(cliente5);
caja1.AgregarCliente(cliente6);
caja1.AgregarCliente(cliente7);


BancoCliente atendido = caja1.AtenderCliente();

Console.WriteLine($"ATENDIDO: {atendido.Nombre}");

caja1.ImprimirColas();