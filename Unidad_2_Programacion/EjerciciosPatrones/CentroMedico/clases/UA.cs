namespace EstructurasLibrary;

public class UA : BaseSanitaria
{
    private List<BaseSanitaria> _bases;

    public UA(string nombre, string direccion)
        : base(nombre, direccion)
    {
        _bases = new List<BaseSanitaria>();
    }

    public void AgregarBase(BaseSanitaria baseSanitaria)
    {
        _bases.Add(baseSanitaria);
    }

    public void EliminarBase(BaseSanitaria baseSanitaria)
    {
        _bases.Remove(baseSanitaria);
    }

    public override int ObtenerCantidadAmbulancias()
    {
        int total = 0;

        foreach (BaseSanitaria b in _bases)
        {
            total += b.ObtenerCantidadAmbulancias();
        }

        return total;
    }

    public override double ObtenerTiempoMedioAsistencia()
    {
        if (_bases.Count == 0)
            return 0;

        double suma = 0;

        foreach (BaseSanitaria b in _bases)
        {
            suma += b.ObtenerTiempoMedioAsistencia();
        }

        return suma / _bases.Count;
    }
}