// IMPORTANTE:
// Para ejecutar la aplicación con `dotnet run` tenés que estar parado
// dentro de la carpeta del proyecto (donde está el archivo .csproj).
//
// Ejemplo de navegación:
// cd src
// cd ConsoleApp
// dotnet run
//
// Si lo ejecutás desde otra carpeta, .NET no va a encontrar el proyecto
// y te va a tirar error (o directamente no va a saber qué correr).
//
// Regla rápida:
// 👉 Si no ves el .csproj, no estás en el lugar correcto.

//Console.WriteLine("Hello, World!");


using Clases;

Usuario cata = new Usuario("Cata", new Iphone());

Usuario juliana = new Usuario("Juliana", new Motorola());

Console.WriteLine(cata.Nombre);
Console.WriteLine(juliana.Nombre);

Console.WriteLine($"Total de Bateria celular de Catalina: {cata.TotalBateria()} puntos");
Console.WriteLine($"Total de Bateria celular de Juliana: {juliana.TotalBateria()} puntos");

cata.Celular.Llamar(juliana.Celular, 100);
Console.WriteLine("Hacemos una llmada de 100 segundos");
Console.WriteLine($"Total de Bateria celular de Juliana: {juliana.TotalBateria()} puntos");
Console.WriteLine($"Total de Bateria celular de Catalina: {cata.TotalBateria()} puntos");


juliana.Celular.Recargar();
Console.WriteLine("Juliana recarga la bateria");
Console.WriteLine($"Total de Bateria celular de Juliana: {juliana.TotalBateria()} puntos");
Console.WriteLine($"Total de Bateria celular de Catalina: {cata.TotalBateria()} puntos");

cata.Celular.Llamar(cata.Celular, 1000);
Console.WriteLine("Hacemos una llmada de 100 segundos");
Console.WriteLine($"Total de Bateria celular de Juliana: {juliana.TotalBateria()} puntos");
Console.WriteLine($"Total de Bateria celular de Catalina: {cata.TotalBateria()} puntos");

