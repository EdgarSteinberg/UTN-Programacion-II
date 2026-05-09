namespace Clases
{
    public class Iphone : Celular
    {
        public override void PerdidaBateria(int duracion)
        {
            this.Bateria.PuntosDeBateria -= duracion * 0.001;
        }
    }

}