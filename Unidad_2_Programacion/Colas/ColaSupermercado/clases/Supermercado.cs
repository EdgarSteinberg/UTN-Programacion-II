namespace EstructurasLibrary;

public class Supermercado
{
    private MyQueue<Persona> _cola;

    public Supermercado()
    {
        _cola = new MyQueue<Persona>();
    }

    public Persona Atender()
    {
        return _cola.Dequeue();
    }

    public void Agregar(Persona nueva)
    {
        var aux = new MyQueue<Persona>();

        bool insertado = false;
        int posicion = 0;

        while (!_cola.IsEmpty())
        {
            Persona actual = _cola.Dequeue();

            // =========================
            // CASO PERSONA MAYOR
            // =========================
            if (nueva.EsMayor && !insertado)
            {
                // Solo puede adelantarse hasta la posición 1
                if (posicion == 1)
                {
                    aux.Enqueue(nueva);
                    insertado = true;
                }

                // Si encuentra otro mayor antes
                else if (posicion > 1 && actual.EsMayor)
                {
                    aux.Enqueue(nueva);
                    insertado = true;
                }
            }

            // =========================
            // CASO EXCELENCIA
            // =========================
            else if (nueva.EsExcelencia && !insertado)
            {
                // Se frena ante un mayor
                // o ante otro excelencia
                if (actual.EsMayor || actual.EsExcelencia)
                {
                    aux.Enqueue(actual);
                    aux.Enqueue(nueva);

                    insertado = true;
                    posicion++;

                    continue;
                }
            }

            aux.Enqueue(actual);
            posicion++;

        }

        // Si nunca se insertó
        if (!insertado)
        {
            aux.Enqueue(nueva);
        }

        // Reconstrucción
        while (!aux.IsEmpty())
        {
            _cola.Enqueue(aux.Dequeue());
        }
    }

    public void MostrarCola()
    {
        var aux = new MyQueue<Persona>();

        while (!_cola.IsEmpty())
        {
            Persona actual = _cola.Dequeue();

            Console.WriteLine(
                $"{actual.Nombre} | Mayor: {actual.EsMayor} | Excelencia: {actual.EsExcelencia}"
            );

            aux.Enqueue(actual);
        }

        // reconstrucción
        while (!aux.IsEmpty())
        {
            _cola.Enqueue(aux.Dequeue());
        }
    }
}