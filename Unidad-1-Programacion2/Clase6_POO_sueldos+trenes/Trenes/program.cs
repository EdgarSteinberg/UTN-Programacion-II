 

public class Formacion
{
    private List<Locomotora> _locomotoras;

    private List<Vagon> _vagones;
    private bool _enMovimiento;

    public bool EnMovimiento
    {
        get { return _enMovimiento; }
        set { _enMovimiento = value; }
    }
    public void AgregarLocomotora(Locomotora locomotora)
    {
        if (!EnMovimiento)
        {
            _locomotoras.Add(locomotora);
        }
    }
}

public class Locomotora
{
    private double _peso;

    public double Peso
    {
        get { return _peso; }
        set { _peso = value; }
    }

    private double _pesoMaximoDeArrastre;

    public double PesoMaximoArrastre
    {
        get { return _pesoMaximoDeArrastre; }
        set { _pesoMaximoDeArrastre = value; }
    }

    private double _velocidadMaxima;

    public double VelocidadMaxima
    {
        get { return _velocidadMaxima; }
        set { _velocidadMaxima = value; }
    }

    public double ArrastreUtil()
    {
        return _pesoMaximoDeArrastre - _peso;
    }
}


public abstract class Vagon
{
    public abstract double PesoMaximo();
}


public class Pasajeros : Vagon
{
    private double _largo;

    public double Largo
    {
        get { return _largo; }
        set { _largo = value; }
    }

    private double _anchoUtil;

    public double AnchoUtil
    {
        get { return _anchoUtil; }
        set { _anchoUtil = value; }
    }

    private int CalcularCantidadDePasajeros()
    {
        if (AnchoUtil <= 2.5)
        {
            return(int) Largo * 8;
        }
        return (int)Largo * 10;
    }

    public override double PesoMaximo()
    {
        return CalcularCantidadDePasajeros() * 80;
    }
}

public class Carga : Vagon
{
    private double _cargaMaxima;

    public double CargaMaxima
    {
        get {return _cargaMaxima;}
        set { _cargaMaxima = value;}
    }

    public override double PesoMaximo()
    {
        return _cargaMaxima + 160;
    }
}