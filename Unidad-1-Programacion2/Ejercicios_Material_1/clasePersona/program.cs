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
Fruta f1 = new Fruta("Roja", 150, true);
Console.WriteLine(f1.EsComestible());



/* ● Crear dos instancias de Ninja, asignar distintos valores para cada uno de los
atributos e invocar las funciones saltar() y ataque(). */


//Ninja 1
Ninja n1 = new Ninja();
n1.ArteMarcial = "Karate";
n1.Arma = "Punos";
n1.Fuerza = 8;
n1.Salto = 80;
n1.Saltar(5);
n1.Ataque();
//Ninja 2
Ninja n2 = new Ninja();
n2.ArteMarcial = "Jujitsu";
n2.Arma = "Katana";
n2.Fuerza = 9;
n2.Salto = 90;
n2.Saltar(6);
n2.Ataque();


/* clase People
● Crear una instancia de cada una de las clases y asignarle valores.
● Mostrar por pantalla los valores. */

Visitante v1 = new Visitante();
v1.Nombre = "Victor";
v1.Apellido = "Ferreira";


Console.WriteLine($"Nombre: {v1.Nombre} Apellido: {v1.Apellido}");

Guardia g1 = new Guardia();
g1.Nombre = "Baby";
g1.Apellido = "Echecopar";

Console.WriteLine($"Nombre del guardia {g1.Nombre} y su apellido : {g1.Apellido}");


// Clase people_1
Visitante_1 v3 = new Visitante_1();
v3.Nombre = "Edgar";
v3.Apellido = "Steinberg";
v3.Presentarse();


Guardia_1 g3 = new Guardia_1();
g3.Nombre = "Ilu";
g3.Apellido = "Pena";
g3.Presentarse();


//clase people_1.1

Visitante2 v4 = new Visitante2();
v4.Nombre = "Sebastian";
v4.Apellido = "Villarreal";
v4.Dni = 1234;
v4.Presentarse();

Guardian2 g4 = new Guardian2();
g4.Nombre = "Juan";
g4.Apellido = "Tomaselli";
g4.Presentarse();

Console.WriteLine(g4.ControlarDocumento(v4.Dni));



//Clase people1_2

Visitante3 v5 = new Visitante3();
v5.Nombre = "Marucha";
v5.Apellido = "Steinberg";
v5.Dni = 12345;

v5.Presentarse();

Guardian3 g5 = new Guardian3();
g5.Nombre = "Estrella";
g5.Apellido = "Steinberg";
g5.Presentarse();

Console.WriteLine(g5.ControlarDocumento(v5.Dni,v5.Nombre, v5.Apellido));