namespace Ejercicio.clases;

public class ArbolGenialogico
{
    private Persona _raiz;
    public Persona Raiz
    {
        get { return _raiz; }
        set { _raiz = value; }
    }

    public void Mostrar()
    {
        Mostrar(Raiz);
    }

}