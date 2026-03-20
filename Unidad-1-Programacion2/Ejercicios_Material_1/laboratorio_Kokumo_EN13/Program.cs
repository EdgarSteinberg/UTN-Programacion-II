Robot robotina = new Robot("Robotina 2000", new Oruga(), 100);
Console.WriteLine(robotina.MostrarInformacion());
robotina.Recorrer(10);
Console.WriteLine(robotina.MostrarInformacion());
/* robotina.Recorrer(50);
Console.WriteLine(robotina.MostrarInformacion()); */




public class Robot
{
    public string MostrarInformacion()
    {
        return $"Numero de serie {this.NumeroSerie} - Potencia {this.PotenciaBase} - TipoTraccion {this.TipoDeTraccion.GetType().Name} -  Autonomia {this.TipoDeTraccion.Autonomia} - Desgaste Por Uso {this.TipoDeTraccion.DesgastePorUso}";
    }
    private string _nroSerie = "";


    public string NumeroSerie
    {
        get { return _nroSerie; }
        set { _nroSerie = value; }
    }


    private int _potenciaBase = 0;

    public int PotenciaBase
    {
        get { return _potenciaBase; }
        set { _potenciaBase = value; }
    }

    private TipoTraccion _tipoDeTraccion;

    public TipoTraccion TipoDeTraccion
    {
        get { return _tipoDeTraccion; }
        set { _tipoDeTraccion = value; }
    }

    public void Recorrer(int distancia)
    {
        this.PotenciaBase -= distancia * this.TipoDeTraccion.DesgastePorUso;
    }

    public Robot(string nroSerie, TipoTraccion tipoTraccion, int potenciaBase)
    {
        this.NumeroSerie = nroSerie;
        this.TipoDeTraccion = tipoTraccion;
        this.PotenciaBase = potenciaBase;
    }
}


public class TipoTraccion
{
    private int _desgastePorUso = 0;

    public int DesgastePorUso
    {
        get { return _desgastePorUso; }
        set { _desgastePorUso = value; }
    }

    private int _autonomia = 0;

    public int Autonomia
    {
        get { return _autonomia; }
        set { _autonomia = value; }
    }
}


public class RuedaDeCaucho : TipoTraccion
{
    public RuedaDeCaucho()
    {
        this.DesgastePorUso = 1;
        this.Autonomia = 100;
    }
}

public class Oruga : TipoTraccion
{
    private string _sensor = "";

    public string Sensor
    {
        get { return _sensor; }
        set { _sensor = value; }
    }

    public Oruga()
    {
        this.DesgastePorUso = 3;
        this.Autonomia = 400;
    }
}


