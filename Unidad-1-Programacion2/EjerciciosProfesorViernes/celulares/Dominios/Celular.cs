namespace celulares.Dominio;

public abstract class Celular
{
    private float _bateria = 5;

    public float Bateria
    {
        get { return _bateria; }
        protected set { _bateria = value; }
    }

    public bool EstaApagado()
    {
        return _bateria <= 0;
    }

    public void RecargarBateria()
    {
        _bateria = 5;
    }

    public abstract void Llamada(int duracion);
}