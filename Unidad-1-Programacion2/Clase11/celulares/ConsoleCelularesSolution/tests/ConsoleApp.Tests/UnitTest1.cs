namespace ConsoleApp.Tests;

using Clases;
public class UnitTest1
{
    [Fact]
    public void TestMotorolaPerdidaBateria()
    {
        //Assert.True(1 > 0); //Primera prueba que el test es exitoso
        Motorola moto = new Motorola();
        Usuario motoUsuario = new Usuario();
        Motorola moto1 = new Motorola();

        motoUsuario.Llamar(moto1, 100);
        double PuntosDeBateriaEsperado = 4.75;
        Assert.AreEqual(PuntosDeBateriaEsperado, moto.Bateria.PuntosDeBateria());
    }

    [Fact]
    public void TestQueFalla()
    {
        Assert.True(1 < 0); //Primera prueba que el test es fallido

    }
}
