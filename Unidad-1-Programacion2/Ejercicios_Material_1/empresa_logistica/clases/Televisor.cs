namespace Ejercicios.clases;

public class Televisor : Producto
{
    private int _voltaje;

    public int Voltaje
    {
        get { return _voltaje; }
        set { _voltaje = value; }
    }

    private bool _esLed;

    public bool EsLed
    {
        get { return _esLed; }
        set { _esLed = value; }
    }

    private bool _esSmart;

    public bool EsSmart
    {
        get { return _esSmart; }
        set { _esSmart = value; }
    }
    public Televisor(int id, string desc, double dim, int voltaje, bool led, bool smart)
    {
        NumeroId = id;
        Descripcion = desc;
        Dimensiones = dim;
        Voltaje = voltaje;
        EsLed = led;
        EsSmart = smart;
    }
}