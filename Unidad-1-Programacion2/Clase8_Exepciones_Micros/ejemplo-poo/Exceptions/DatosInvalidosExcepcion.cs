namespace ejemplo_poo.Exceptions;


public class DatosInvalidosException : Exception
{
    public DatosInvalidosException() : base("Datos invalidos")
    {

    }
    public DatosInvalidosException(string message) : base(message)
    {

    }
}