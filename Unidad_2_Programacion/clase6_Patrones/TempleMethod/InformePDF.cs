public class InformePDF : Informe
{
    protected override void PresentarInforme(List<string> alumnosActivos)
    {
        Console.WriteLine("Estamos generando un PDF....");
        foreach (string unAlumno in alumnosActivos)
        {
            Console.WriteLine("Alumno: " + unAlumno);
        }
        Console.WriteLine("Fin de la generación del PDF");
    }
}