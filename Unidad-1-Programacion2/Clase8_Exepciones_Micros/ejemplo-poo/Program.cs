

using ejemplo_poo.Dominio;
using ejemplo_poo.Helpers;


Persona unaPersona = new Alumno("Leo", "Fernandez", "leo_perez@email.com", "12345", 8.5f, 22); // upcasting
Alumno unAlumno = (Alumno)unaPersona; //downcasting

unaPersona = new Docente("Matemáticas", "Juan", "Perez", "juan@mail.com", 35, 10);
//unaPersona = null;


unaPersona.SetApellido("");
Console.WriteLine(unaPersona.GetApellido());
/*  
 unaPersona.SetNombre("Juan");
 unaPersona.SetApellido("Perez");
 unaPersona.SetEmail("juan.perez@example.com"); 
 */


try
{

    Printer.Print(unAlumno);
    Printer.Print(unaPersona);
}
catch (NombreInvalidoException nre)
{

    Console.WriteLine($"Revise el nombre");
}

catch (ApellidoInvalidoException nre)
{

    Console.WriteLine($"Revise el apellido");
}
catch (Exception e)
{
    Console.WriteLine($"Fallo al imprimir {e.Message}");
}
finally
{
    Console.WriteLine($"Se ejecuta haya error o no");
}

Console.WriteLine($"Terminado");