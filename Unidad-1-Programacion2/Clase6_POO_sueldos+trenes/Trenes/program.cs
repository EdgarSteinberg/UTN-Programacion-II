
internal class Program
{
    private static void Main(string[] args)
    {
        //Primero creás una formación:
        Formacion objFormacion1 = new Formacion();

        //Después creás una locomotora:
        Locomotora objLocomotora1 = new Locomotora();

        //Y luego la agregás a la formación con el método que hiciste:
        objFormacion1.AgregarLocomotora(objLocomotora1);


        // crear vagones de pasajeros
        Pasajeros p1 = new Pasajeros();
        p1.Largo = 10;
        p1.AnchoUtil = 2;

        Pasajeros p2 = new Pasajeros();
        p2.Largo = 10;
        p2.AnchoUtil = 3;

        // agregarlos a la formación
        objFormacion1.AgregarVagon(p1);
        objFormacion1.AgregarVagon(p2);

        //El total de pasajeros que puede transportar una formación
        Console.WriteLine("Total de pasajeros de la formación: " + objFormacion1.TotalDePasajeros());

        //2. Cuántos vagones livianos tiene una formación; un vagón es liviano si su peso máximo es menor a 2500 kg
        Pasajeros p3 = new Pasajeros();
        p3.Largo = 3;
        p3.AnchoUtil = 2;
        objFormacion1.AgregarVagon(p3);
        Console.WriteLine($"Cantidad de vagones livianos: {objFormacion1.CantidadDeVagonesLivianos()}");
    }
}

public class Formacion
{
    private List<Locomotora> _locomotoras = new List<Locomotora>();
    private List<Vagon> _vagones = new List<Vagon>();
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

    public void AgregarVagon(Vagon vagon)
    {
        if (!EnMovimiento)
        {
            _vagones.Add(vagon);
        }
    }

    public int TotalDePasajeros()
    {
        int total = 0;

        foreach (Vagon vagon in _vagones)
        {
            if (vagon is Pasajeros pasajeros)
            {
                total += pasajeros.CalcularCantidadDePasajeros();
            }
        }

        return total;
    }


    public int CantidadDeVagonesLivianos()
    {
        int cantidad = 0;

        foreach (Vagon vagon in _vagones)
        {
            if (vagon.PesoMaximo() < 2500)
            {
                cantidad++;
            }
        }

        return cantidad;
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

    public int CalcularCantidadDePasajeros()
    {
        if (AnchoUtil <= 2.5)
        {
            return (int)(Largo * 8);
        }
        return (int)(Largo * 10);
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
        get { return _cargaMaxima; }
        set { _cargaMaxima = value; }
    }

    public override double PesoMaximo()
    {
        return _cargaMaxima + 160;
    }
}