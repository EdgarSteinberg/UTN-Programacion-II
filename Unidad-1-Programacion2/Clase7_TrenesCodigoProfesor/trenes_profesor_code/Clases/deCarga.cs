namespace trenes_profesor_code.Clases;


public class VagonDeCarga : Vagon
{
    private double _cargaMaxima;

    private double CargaMaxima
    {
        get { return _cargaMaxima; }
        set { _cargaMaxima = value; }
    }

     public VagonDeCarga(int pAnchoUtil, int pLargo, int pAncho, double pCargaMaxima)
    {
        this.AnchoUtil = pAnchoUtil;
        this.Largo = pLargo;
        this.Ancho = pAncho;
        this.CargaMaxima = pCargaMaxima;
    }
    public override double PesoMaximo()
    {
        return this.CargaMaxima + 160;
    }
}