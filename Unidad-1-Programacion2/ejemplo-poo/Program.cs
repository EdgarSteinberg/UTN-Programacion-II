

/* Persona unaPersona = new Persona(); */
/* Persona unaPersona = new Alumno(); */

using ejemplo_poo.Dominio;
using ejemplo_poo.Helpers;


Persona unaPersona = new Alumno("12345", 8.5f); // upcasting
Alumno unAlumno = (Alumno)unaPersona; //downcasting

unaPersona = new Docente("Matemáticas", 20); 

unaPersona.SetNombre("Juan");
unaPersona.SetApellido("Perez");
unaPersona.SetEmail("juan.perez@example.com");
/* unaPersona.Legajo = "N100";
unaPersona.Promedio = 8.5F; */

/* Console.WriteLine(unaPersona.Saludar()); */

/* ejemplo_poo.Helpers.Printer.Print(unaPersona); */
Console.WriteLine(unAlumno.EstoyPresente()); // o sino castear (((alumno) unaPersona).EstoyPresente());
Printer.Print(unAlumno);
Printer.Print(unaPersona);