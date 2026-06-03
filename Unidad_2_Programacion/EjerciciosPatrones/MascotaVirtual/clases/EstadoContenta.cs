namespace EstructurasLibrary;

public class EstadoContenta : IEstadoMascota
{
    public void Comer(Mascota mascota)
    {
        mascota.NivelContenta += 1;
        Console.WriteLine("La mascota está contenta y aumenta su nivel de felicidad.");
    }

    public void Jugar(Mascota mascota)
    {
        mascota.NivelContenta += 2;
        Console.WriteLine("La mascota juega felizmente.");
    }

    public bool PuedeJugar()
    {
        return true;
    }
}