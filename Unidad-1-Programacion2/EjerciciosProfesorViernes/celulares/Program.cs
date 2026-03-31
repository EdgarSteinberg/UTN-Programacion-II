using celulares.Dominio;

Persona juliana = new Persona();
juliana.Nombre = "Juliana";
juliana.Celular = new MotorolaG5();

juliana.Celular.Llamada(1);

Console.WriteLine($"{juliana.Nombre}:");
Console.WriteLine($"¿Celular apagado? {juliana.Celular.EstaApagado()}");
Console.WriteLine($"Batería restante: {juliana.Celular.Bateria}");

Persona catalina = new Persona();
catalina.Nombre = "Catalina";
catalina.Celular = new Iphone();

catalina.Celular.Llamada(5);

Console.WriteLine();

Console.WriteLine($"{catalina.Nombre}:");
Console.WriteLine($"¿Celular apagado? {catalina.Celular.EstaApagado()}");
Console.WriteLine($"Batería restante: {catalina.Celular.Bateria}");


juliana.Celular.Llamada(1);
catalina.Celular.Llamada(5);

Console.WriteLine($"{juliana.Nombre}: {juliana.Celular.Bateria} - Apagado: {juliana.Celular.EstaApagado()}");
Console.WriteLine($"{catalina.Nombre}: {catalina.Celular.Bateria} - Apagado: {catalina.Celular.EstaApagado()}");

catalina.Celular.Llamada(50);

Console.WriteLine($"{catalina.Nombre}: {catalina.Celular.Bateria} - Apagado: {catalina.Celular.EstaApagado()}");

catalina.Celular.RecargarBateria();

Console.WriteLine($"Luego de recargar, {catalina.Nombre} tiene {catalina.Celular.Bateria}");