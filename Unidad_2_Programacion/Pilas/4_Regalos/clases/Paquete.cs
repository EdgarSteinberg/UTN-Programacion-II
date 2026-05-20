namespace EstructurasLibrary;

public class Paquete
{
    private int _tamanio;
    public int Tamanio
    {
        get { return _tamanio; }
        set { _tamanio = value; }
    }

    public Paquete(int tamanio)
    {
        Tamanio = tamanio;
    }

}