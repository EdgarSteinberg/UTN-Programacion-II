namespace EstructurasLibrary;

public class ProcesamientoEncrypt : ProcesamientoStrategy
{
    public Documento ProcesarDocumento(Documento documento)
    {
        string text = $"Encriptar documento {documento.Texto}";
        string nuevo =  $"{documento.Nombre} Encriptando ";

        documento.Nombre = nuevo;
        documento.Texto = text;

        return documento;
    }
}