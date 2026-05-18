namespace EstructurasLibrary;

public class Carta
{
    private string _remitente = "";
    public string Remitente
    {
        get { return _remitente; }
        set { _remitente = value; }
    }

    private string _destinatario = "";
    public string Destinatario
    {
        get { return _destinatario; }
        set { _destinatario = value; }
    }

    private string _contenido = "";
    public string Contenido
    {
        get { return _contenido; }
        set { _contenido = value; }
    }

    public Carta(string remitente, string destinatario, string contenido)
    {
        Remitente = remitente;
        Destinatario = destinatario;
        Contenido = contenido;
    }

}