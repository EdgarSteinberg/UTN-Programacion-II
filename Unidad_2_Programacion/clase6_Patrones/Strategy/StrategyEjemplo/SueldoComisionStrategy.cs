namespace EstructurasLibrary;

public class SueldoComisionStrategy : CalcularSueldosStrategy
{
    public override int CalcularSueldoS(EmpladoStrategy empleado)
    {
        return empleado.Sueldo + (empleado.Ventas * 10);
    }
}