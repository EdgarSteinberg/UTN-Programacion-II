namespace EstructurasLibrary;

public class Psupermercado
{
    public const int MINIMO_EDAD_MAYOR = 70;

    private MyQueue<Persona> _regulares;
    private MyQueue<Persona> _excelencia;
    private MyQueue<Persona> _mayores;

    public Psupermercado()
    {
        _regulares = new MyQueue<Persona>();
        _excelencia = new MyQueue<Persona>();
        _mayores = new MyQueue<Persona>();
    }

    public void Recibir(Persona persona)
    {
        if (persona.EsMayor)
        {
            _mayores.Enqueue(persona);
            return;
        }

        if (persona.EsExcelencia)
        {
            _excelencia.Enqueue(persona);
            return;
        }

        _regulares.Enqueue(persona);
    }

    public void Atender()
    {
        MyQueue<Persona> cola;

        if (!_mayores.IsEmpty())
        {
            cola = _mayores;
        }
        else if (!_excelencia.IsEmpty())
        {
            cola = _excelencia;
        }
        else if (!_regulares.IsEmpty())
        {
            cola = _regulares;
        }
        else
        {
            throw new Exception("No hay clientes");
        }

        Persona persona = cola.Dequeue();

        Console.WriteLine($"Atendiendo a: {persona.Nombre}");
    }
}