/* get → método que devuelve el valor
set → método que recibe un valor */


//Clase Persona
Persona p = new Persona();

p.Nombre = "Edgar";
p.Apellido = "Steinberg";

Console.WriteLine(p.Saludar());


//Clase Vehiculo
Vehiculo v = new Vehiculo();

v.Marca = "Mercedes";
v.Modelo = "Clase E";
v.SetPatente("ABC123"); // opcional, si querés asignarla
v.MostrarInfo();

Console.WriteLine($"Vehículo: {v.Marca} {v.Modelo}");


//Clase Articulo
Articulo a = new Articulo();

a.SetMarca("Samsung");
a.SetModelo("S23");

// Esto NO funciona
// Console.WriteLine(a.marca);
a.MostrarInfo();


//Clase cine
Cine cine = new Cine();

cine.Pelicula = "Batman";
cine.Horario = 20;

Console.WriteLine(cine.ObtenerCartelera());



//Clase cine2
CineCartelera cine1 = new CineCartelera();
cine1.Pelicula2 = "BadBoys";
cine1.Horario2 = 18;

CineCartelera cine2 = new CineCartelera();
cine2.Pelicula2 = "BadBoys2";
cine2.Horario2 = 19;

cine1.MostrarDatos();
cine2.MostrarDatos();

cine1.Pelicula2 = "Joker";
cine1.Horario2 = 22;

Console.WriteLine("Después del cambio:");

cine1.MostrarDatos();
cine2.MostrarDatos();


//Clase Frutas
Fruta f1 = new Fruta("Roja",150, true);
Console.WriteLine(f1.EsComestible());
