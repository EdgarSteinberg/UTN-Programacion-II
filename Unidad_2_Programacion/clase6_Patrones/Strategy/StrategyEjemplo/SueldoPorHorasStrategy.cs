namespace EstructurasLibrary;

public class SueldoPorHorasStrategy : CalcularSueldosStrategy
{
    public override int CalcularSueldoS(EmpladoStrategy empleado)
    {
        return empleado.Sueldo * empleado.HorasTrabajadas;
    }
}