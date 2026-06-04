namespace EstructurasLibrary;


public class Empresa
{
    private ProcesamientoStrategy _procesamientoStrategy;

    public Empresa(ProcesamientoStrategy procesamientoStrategy)
    {
        _procesamientoStrategy = procesamientoStrategy;
    }

    public void SetProcesamientoStrategy(ProcesamientoStrategy procesamientoStrategy)
    {
        _procesamientoStrategy = procesamientoStrategy;
    }

    public Documento ProcesarDocumento(Documento documento)
    {
        return _procesamientoStrategy.ProcesarDocumento(documento);
    }
}