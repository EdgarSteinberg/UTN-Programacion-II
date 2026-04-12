namespace Clase8_Exepciones_Micros.clases;

public abstract class Persona
{
    private Persona _jefe;
    public Persona Jefe
    {
        get { return _jefe; }
        set
        {
            _jefe = value;

            if (value != null)
            {
                _esJefe = false;
            }
        }
    }
    private bool _esJefe;
    public bool EsJefe
    {
        get { return _esJefe; }
        set
        {
            _esJefe = value;

            // Si es jefe → no puede tener jefe
            if (value)
            {
                _jefe = null;
            }
        }
    }

    public abstract bool AceptaSubir(Micro micro);
}