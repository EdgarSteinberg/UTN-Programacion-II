namespace EstructurasLibrary;


public class MoverImagenAccion : Accion
{

    private string _posicionAnterior;
    public string PosicionAnterior
    {
        get { return _posicionAnterior; }
        set { _posicionAnterior = value; }
    }
    
        private string _posicionNueva;
    public string PosicionNueva
    {
        get { return _posicionNueva; }
        set { _posicionNueva = value; }
    }
 

    public MoverImagenAccion(string anterior, string nueva)
    {
        PosicionAnterior = anterior;
        PosicionNueva = nueva;
    }

    public void Ejecutar()
    {
        Console.WriteLine($"Moviendo imagen a {PosicionNueva}");
    }

    public void Deshacer()
    {
        Console.WriteLine($"Volviendo imagen a {PosicionAnterior}");
    }
}