namespace EstructurasLibrary;

public class Destino
{
    private string _nombre;
    private int _diferenciaHoraria;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public int DiferenciaHoraria
    {
        get { return _diferenciaHoraria; }
        set { _diferenciaHoraria = value; }
    }

    public Destino(string nombre, int diferencia)
    {
        _nombre = nombre;
        _diferenciaHoraria = diferencia;
    }

    public DateTime CalcularHora(DateTime horaLocal)
    {
        return horaLocal.AddHours(_diferenciaHoraria);
    }
}