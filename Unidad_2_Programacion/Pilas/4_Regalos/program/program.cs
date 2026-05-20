using EstructurasLibrary;

MesaPrincipal mesa = new MesaPrincipal();

Paquete paquete1 = new Paquete(1);
Paquete paquete2 = new Paquete(5);
Paquete paquete3 = new Paquete(2);
Paquete paquete4 = new Paquete(3);

mesa.AgregarPaquete(paquete1);
mesa.AgregarPaquete(paquete2);
mesa.AgregarPaquete(paquete3);
mesa.AgregarPaquete(paquete4);

/* mesa.OrdenarPaquetes(); */
mesa.Mostrar();