namespace EstructurasLibrary;

public class SueldoFijoStrategy : CalcularSueldosStrategy
{
    public override int CalcularSueldoS(EmpladoStrategy empleado)
    {
        return empleado.Sueldo;
    }
}
