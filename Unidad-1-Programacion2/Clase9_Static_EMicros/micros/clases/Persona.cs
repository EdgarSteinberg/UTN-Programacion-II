namespace Ejercicios.clases;

public abstract class Persona
{
    private bool _esJefe;
    public bool EsJefe
    {
        get { return _esJefe; }
        set { _esJefe = value; }
    }
    
    private Persona _jefe;
    public Persona Jefe
    {
        get { return _jefe; }
        set { _jefe = value; }
    }
    
    public abstract bool AceptaSubir(Micro micro);
}