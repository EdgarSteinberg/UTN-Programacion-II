namespace Clases
{
    public class Motorola : Celular
    {
        public override void PerdidaBateria(int duracion)
        {
            this.Bateria.PuntosDeBateria -= 0.25;
        }
    }

}