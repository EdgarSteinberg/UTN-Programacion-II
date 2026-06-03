namespace EstructurasLibrary;

public interface IEstadoMascota
{
    void Comer(Mascota mascota);

    void Jugar(Mascota mascota);

    bool PuedeJugar();
}