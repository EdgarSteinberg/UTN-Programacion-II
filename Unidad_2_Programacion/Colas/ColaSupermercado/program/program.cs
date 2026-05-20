

using EstructurasLibrary;

Persona objPersona = new Persona("Marta", true, false);
Persona objPersona1 = new Persona("Sebastian", false, true);
Persona objPersona2 = new Persona("Edgar", false, false);
Persona objPersona3 = new Persona("Nadia", false, false);
Persona objPersona4 = new Persona("Mariana", false, false);
Persona objPersona5 = new Persona("Adriana", true, false);

Supermercado colaSupermercado = new Supermercado();

Console.WriteLine("Agregando personas a la cola...\n");

colaSupermercado.Agregar(objPersona);
colaSupermercado.Agregar(objPersona1);
colaSupermercado.Agregar(objPersona2);
colaSupermercado.Agregar(objPersona3);
colaSupermercado.Agregar(objPersona4);
colaSupermercado.Agregar(objPersona5);

Console.WriteLine("Estado final de la cola:\n");

colaSupermercado.MostrarCola();