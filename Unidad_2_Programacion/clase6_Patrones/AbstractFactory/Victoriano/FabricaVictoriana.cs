namespace EstructurasLibrary;

public class FabricaVictoriana : FabricaAbstracta
{
    public override Mesa CrearMesa()
    {
        MesaVictoriana objMesa = new MesaVictoriana();
        objMesa.Estilo = "MesaVictoriana";
        return objMesa;
    }

    public override Silla CrearSilla()
    {
        throw new NotImplementedException();
    }
}