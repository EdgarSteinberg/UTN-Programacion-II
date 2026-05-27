namespace EstructurasLibrary;

public class Archivo : Elemento
{
    public Archivo(string nombre, int tamano) : base(nombre, tamano)
    {
        
    }

    public override int DevolverTamano()
    {
        return this.Tamano;
    }
}