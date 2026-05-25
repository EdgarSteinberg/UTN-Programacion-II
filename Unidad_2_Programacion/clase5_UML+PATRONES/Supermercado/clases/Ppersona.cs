namespace EstructurasLibrary;

public class Ppersona
{
    public string Nombre { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public bool EsExcelencia { get; set; }

    public Ppersona(string nombre, DateTime fechaNacimiento, bool esExcelencia)
    {
        Nombre = nombre;
        FechaNacimiento = fechaNacimiento;
        EsExcelencia = esExcelencia;
    }

    public int CalcularEdad()
    {
        int edad = DateTime.Now.Year - FechaNacimiento.Year;

        if (DateTime.Now < FechaNacimiento.AddYears(edad))
        {
            edad--;
        }

        return edad;
    }

    public bool EsMayor()
    {
        return CalcularEdad() >= Psupermercado.MINIMO_EDAD_MAYOR;
    }
}