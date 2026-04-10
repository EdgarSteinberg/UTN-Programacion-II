namespace trenes_profesor_code.Clases;


public class VagonDePasajero : Vagon
{
    public VagonDePasajero(int pAnchoUtil, int pLargo, int pAncho)
    {
        this.AnchoUtil = pAnchoUtil;
        this.Largo = pLargo;
        this.Ancho = pAncho;
    }

    public int CantidadDePasajeros()
    {
        if (this.AnchoUtil <= (double)2.5)
        {
            return (int)(this.Largo * 8);
        }
        else
        {
            return (int)(this.Largo * 10);
        }
    }

    public override double PesoMaximo()
    {
        return this.CantidadDePasajeros() * 80;
    }
}