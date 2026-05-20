
using EstructurasLibrary;

Cliente cliente1 = new Cliente("Edgar");
Cliente cliente2 = new Cliente("Bernardo");
Cliente cliente3 = new Cliente("Steinberg");
Cliente cliente4 = new Cliente("Ramona");
Cliente cliente5 = new Cliente("Iluminada");
Cliente cliente6 = new Cliente("Pena");
Cliente cliente7 = new Cliente("Julio");
Cliente cliente8 = new Cliente("Leon");
Cliente cliente9 = new Cliente("Steinberg");
Cliente cliente10 = new Cliente("ROCKO-MARA-LUNA-ESTRELLA");


SistemaPago sistemaPago = new SistemaPago();

sistemaPago.AgregarCliente(cliente1);
sistemaPago.AgregarCliente(cliente2);
sistemaPago.AgregarCliente(cliente3);
sistemaPago.AgregarCliente(cliente4);
sistemaPago.AgregarCliente(cliente5);
sistemaPago.AgregarCliente(cliente6);
sistemaPago.AgregarCliente(cliente7);
sistemaPago.AgregarCliente(cliente8);
sistemaPago.AgregarCliente(cliente9);
sistemaPago.AgregarCliente(cliente10);

sistemaPago.ImprimirFilas();