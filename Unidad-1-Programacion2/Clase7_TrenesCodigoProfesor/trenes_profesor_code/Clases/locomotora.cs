namespace trenes_profesor_code.Clases;

public class Locomotora
{
    private double _peso;

    public double Peso
    {
        get { return _peso; }
        set { _peso = value; }
    }

    private double _velocidadMaxima;

    public double VelocidadMaxima
    {
        get { return _velocidadMaxima; }
        set { _velocidadMaxima = value; }
    }

    private double _arrastrePesoUtil;

    public double ArrastrePesoUtil
    {
        get { return _arrastrePesoUtil; }
        set { _arrastrePesoUtil = value; }
    }

    public Locomotora(double peso, double VelocidadMaxima, double arrastrePesoUtil)
    {
        this.Peso = peso;
        this.VelocidadMaxima = VelocidadMaxima;
        this.ArrastrePesoUtil = arrastrePesoUtil;
    }
}