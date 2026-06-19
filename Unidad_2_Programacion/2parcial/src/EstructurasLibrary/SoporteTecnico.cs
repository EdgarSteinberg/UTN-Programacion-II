namespace EstructurasLibrary;

public abstract class SoporteTecnico
{
    protected SoporteTecnico _siguiente;

    public void SetSiguiente(SoporteTecnico siguiente)
    {
        _siguiente = siguiente;
    }

    public abstract void Atender(Solicitud solicitud);
}