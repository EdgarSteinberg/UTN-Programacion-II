public class InformeCSV : Informe
{
    protected override void PresentarInforme(List<string> alumnosActivos)
    {
        Console.WriteLine("Informe en formato CSV:");
        foreach (string unAlumno in alumnosActivos)
        {
            Console.WriteLine (", "+ unAlumno);
        }
        
    }
}