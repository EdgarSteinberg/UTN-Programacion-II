namespace EstructurasLibrary;


public class Browser
{
    private History _history;
    public History Historial
    {
        get { return _history; }
        set { _history = value; }
    }

    private string _currentUrl;
    public string CurrentUrl
    {
        get { return _currentUrl; }
        set { _currentUrl = value; }
    }

    public Browser()
    {
        this.Historial = new History();
    }

    public void GoTo(string url)
    {
        this.Historial.Push(this.CurrentUrl);
        this.CurrentUrl = url;
    }

    public void GoToBack()
    {
        this.CurrentUrl = this.Historial.Pop();
    }

    public void PrinHistory()
    {
        this.Historial.PrintHistory();
    }
}