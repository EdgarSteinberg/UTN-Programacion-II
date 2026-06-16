
namespace EstructurasLibrary;

public class ProcesamientoCompresion : ProcesamientoStrategy
{
    public Documento ProcesarDocumento(Documento documento)
    {
        string text = $"Comprimir documento {documento.Texto}";
        string nuevo =  $"{documento.Nombre} zip ";

        documento.Nombre = nuevo;
        documento.Texto = text;

        return documento;
    }
}