namespace EstructurasLibrary;

public class BancoCaja
{
    private MyQueue<BancoCliente> _premium;
    public MyQueue<BancoCliente> Premium
    {
        get { return _premium; }
        set { _premium = value; }
    }

    private MyQueue<BancoCliente> _comunes;
    public MyQueue<BancoCliente> Comunes
    {
        get { return _comunes; }
        set { _comunes = value; }
    }

    public BancoCaja()
    {
        _premium = new MyQueue<BancoCliente>();
        _comunes = new MyQueue<BancoCliente>();
    }

    public void AgregarCliente(BancoCliente nuevo)
    {
        if (nuevo.EsPremium)
        {
            InsertarConPrioridad(_premium, nuevo);
        }
        else
        {
            InsertarConPrioridad(_comunes, nuevo);
        }
    }

    public BancoCliente AtenderCliente()
    {
        // 1. prioridad embarazada
        BancoCliente embarazada = BuscarEmbarazada(Premium);

        if (embarazada != null)
            return embarazada;

        embarazada = BuscarEmbarazada(Comunes);

        if (embarazada != null)
            return embarazada;

        // 2. premium domina
        if (CantidadPremium() > 2)
        {
            return Premium.Dequeue();
        }

        // 3. alternancia (todavía faltaría)

        return null;
    }
    private BancoCliente BuscarEmbarazada(MyQueue<BancoCliente> cola)
    {
        var aux = new MyQueue<BancoCliente>();
        BancoCliente encontrada = null;

        while (!cola.IsEmpty())
        {
            BancoCliente actual = cola.Dequeue();

            if (encontrada == null && actual.EsMujer && actual.EstaEmbarazada)
            {
                encontrada = actual;
            }
            else
            {
                aux.Enqueue(actual);
            }
        }

        while (!aux.IsEmpty())
        {
            cola.Enqueue(aux.Dequeue());
        }

        return encontrada;
    }

    public void InsertarConPrioridad(MyQueue<BancoCliente> cola, BancoCliente nuevo)
    {
        if (nuevo.EsMujer && nuevo.EstaEmbarazada)
        {
            var aux = new MyQueue<BancoCliente>();

            aux.Enqueue(nuevo);

            while (!cola.IsEmpty())
            {
                aux.Enqueue(cola.Dequeue());
            }

            while (!aux.IsEmpty())
            {
                cola.Enqueue(aux.Dequeue());
            }
        }
        else
        {
            cola.Enqueue(nuevo);
        }
    }

    public int CantidadPremium()
    {
        var auxPremium = new MyQueue<BancoCliente>();
        int cantidad = 0;

        while (!Premium.IsEmpty())
        {
            BancoCliente actual = Premium.Dequeue();
            cantidad++;

            auxPremium.Enqueue(actual);
        }

        while (!auxPremium.IsEmpty())
        {
            Premium.Enqueue(auxPremium.Dequeue());
        }
        return cantidad;
    }
    public void ImprimirColas()
    {
        var auxComunes = new MyQueue<BancoCliente>();
        var auxPremium = new MyQueue<BancoCliente>();

        while (!Comunes.IsEmpty())
        {
            BancoCliente actual = Comunes.Dequeue();
            Console.WriteLine(
                $"{actual.Nombre} | " +
                $"Operación: {actual.Operacion} | " +
                $"Premium: {actual.EsPremium} | " +
                $"Mujer: {actual.EsMujer} | " +
                $"Embarazada: {actual.EstaEmbarazada}"
                );
            auxComunes.Enqueue(actual);
        }

        while (!auxComunes.IsEmpty())
        {
            Comunes.Enqueue(auxComunes.Dequeue());
        }

        while (!Premium.IsEmpty())
        {
            BancoCliente actual = Premium.Dequeue();
            Console.WriteLine(
                $"{actual.Nombre} | " +
                $"Operación: {actual.Operacion} | " +
                $"Premium: {actual.EsPremium} | " +
                $"Mujer: {actual.EsMujer} | " +
                $"Embarazada: {actual.EstaEmbarazada}"
                );
            auxPremium.Enqueue(actual);
        }

        while (!auxPremium.IsEmpty())
        {
            Premium.Enqueue(auxPremium.Dequeue());
        }
    }
}