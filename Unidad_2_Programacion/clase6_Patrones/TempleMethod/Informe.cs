public abstract class Informe
{
    public void GenerarInformeTemplateMethod()
    {
        List<string> alumnos = RecopilarDatos();
        List<string> resultados = AnalizarDatos(alumnos);
        PresentarInforme(resultados);
    }

    private List<string> RecopilarDatos()
    {
        List<string> alumnos = new List<string>();
        alumnos.Add("Juan");
        alumnos.Add("María");
        alumnos.Add("Pedro");
        alumnos.Add("Ana");
        alumnos.Add("Pablo");
        alumnos.Add("Paula");
        alumnos.Add("Luis");
        return alumnos;
    }
    private  List<string> AnalizarDatos(List<string> alumnos)
    {
        List<string> resultados = new List<string>();
        foreach (string unAlumno in alumnos)
        {
            if (!unAlumno.StartsWith("P"))
            {
                resultados.Add(unAlumno);
            }
        }

        return resultados;
    }
    protected abstract void PresentarInforme(List<string> alumnosActivos);
}