namespace ejemplo_poo.Exceptions;

public class NombreInvalidoException : DatosInvalidosException
{
    public NombreInvalidoException(): base("Nombre invalido")
    {
         
    }

      public NombreInvalidoException(string message): base(message)
    {
         
    }
}