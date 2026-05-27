namespace EstructurasLibrary;

public class FabriacaEscandinavo : FabricaAbstracta
{
    public override Mesa CrearMesa()
    {
        return new MesaEscandinavo();
    }

    public override Silla CrearSilla()
    {
        return new SillaEscandinavo();
    }
}