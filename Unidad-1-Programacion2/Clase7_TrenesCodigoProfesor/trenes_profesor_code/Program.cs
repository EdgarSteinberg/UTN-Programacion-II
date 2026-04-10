using trenes_profesor_code.Clases;



Locomotora locomotora1 = new Locomotora(10, 100, 1000);
Formacion formacion = new Formacion(locomotora1);

formacion.EstaEnMovimiento = false;

Deposito deposito = new Deposito();

deposito.AgregarLocomotoraEnFormacion(locomotora1, formacion);