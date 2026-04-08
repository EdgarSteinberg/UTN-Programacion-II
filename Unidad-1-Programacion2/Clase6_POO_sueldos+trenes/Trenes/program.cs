
internal class Program
{
    private static void Main(string[] args)
    {
        //Primero creás una formación:
        Formacion objFormacion1 = new Formacion();

        //Después creás una locomotora:
        Locomotora objLocomotora1 = new Locomotora();
        objLocomotora1.VelocidadMaxima = 80; //Velocidad maxima
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

        //3La velocidad máxima de una formación, que es el mínimo entre las velocidades máximasde las locomotoras
        Console.WriteLine($"Velocidad maxima de la formacion {objFormacion1.VelocidadMaximaFormacion()}");


        //4 Si una formación es eficiente; es eficiente si cada una de sus locomotoras arrastra, almenos, 5 veces su peso (el de la locomotora misma).
        objLocomotora1.Peso = 1000;
        objLocomotora1.PesoMaximoArrastre = 12000;

        Console.WriteLine($"La Formacion es eficiente? {objFormacion1.esEficiente()}");

        //5. Si una formación puede moverse. Una formación puede moverse si el arrastre útil total de las locomotoras es mayor o igual al peso máximo total de los vagones
        Locomotora objLocomotora2 = new Locomotora();
        objLocomotora2.Peso = 1000;
        objLocomotora2.PesoMaximoArrastre = 12000;
        objLocomotora2.VelocidadMaxima = 80;

        /*    objFormacion1.AgregarLocomotora(objLocomotora2); */
        Console.WriteLine($"La formación puede moverse: {objFormacion1.PuedeMoverse()}");

        /*  6. Cuántos kilos de empuje le faltan a una formación para poder moverse, que es: 0 si ya se
            puede mover, y (peso máximo total de los vagones – arrastre útil total de las locomotoras)
            en caso contrario */

        Console.WriteLine($"Le faltan {objFormacion1.CuantoLeFaltaParaMoverse()} kg de empuje para moverse");
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

    public bool esEficiente()
    {
        foreach (Locomotora locomotora in _locomotoras)
        {
            if (locomotora.ArrastreUtil() < locomotora.Peso * 5)
            {
                return false;
            }
        }

        return true;
    }

    public double VelocidadMaximaFormacion()
    {
        double minima = _locomotoras[0].VelocidadMaxima;

        foreach (Locomotora locomotora in _locomotoras)
        {
            if (locomotora.VelocidadMaxima < minima)
            {
                minima = locomotora.VelocidadMaxima;
            }
        }

        return minima;
    }

    public bool PuedeMoverse()
    {
        double arratreTotal = 0;
        double pesoTotal = 0;

        foreach (Locomotora locomotora in _locomotoras)
        {
            arratreTotal += locomotora.ArrastreUtil();
        }

        foreach (Vagon vagon in _vagones)
        {
            pesoTotal += vagon.PesoMaximo();
        }

        return arratreTotal >= pesoTotal;
    }

    public double CuantoLeFaltaParaMoverse()
    {
        double pesoMaximoTotalVagones = 0;
        double arrastreUtilTotalLocomotoras = 0;

        foreach (Vagon vagon in _vagones)
        {
            pesoMaximoTotalVagones += vagon.PesoMaximo();
        }

        foreach (Locomotora locomotora in _locomotoras)
        {
            arrastreUtilTotalLocomotoras += locomotora.ArrastreUtil();
        }

        if (arrastreUtilTotalLocomotoras >= pesoMaximoTotalVagones)
        {
            return 0;
        }

        return pesoMaximoTotalVagones - arrastreUtilTotalLocomotoras;
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