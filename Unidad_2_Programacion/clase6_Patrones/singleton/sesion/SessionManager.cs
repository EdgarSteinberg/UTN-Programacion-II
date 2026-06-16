namespace EstructurasLibrary;

public class SessionManager
{
    private static SessionManager _instancia;

    private Usuario _usuario;
    public Usuario Usuario
    {
        get { return _usuario; }
        set { _usuario = value; }
    }

    private SessionManager()
    {
    }

    public static SessionManager GetInstance()
    {
        if (_instancia == null)
        {
            _instancia = new SessionManager();
        }

        return _instancia;
    }



}