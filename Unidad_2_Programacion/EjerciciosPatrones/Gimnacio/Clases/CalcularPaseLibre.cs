namespace EstructurasLibrary;


public class CalcularPaseLibre : ICalcularCuota
{
     
    public decimal Costo(Socio s, Gimnasio g)
    {
         return Configuracion.PRECIO_PASE_LIBRE;
    }
}