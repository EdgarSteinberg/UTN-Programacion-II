namespace EstructurasLibrary;

public class SistemaTarea
{
    private MyQueue<Tarea> _colaTareas;

    public MyQueue<Tarea> ColaTareas
    {
        get { return _colaTareas; }
        set { _colaTareas = value; }
    }

    public SistemaTarea()
    {
        _colaTareas = new MyQueue<Tarea>();
    }

    public void AgregarTarea(Tarea nuevaTarea)
    {
        var aux = new MyQueue<Tarea>();
        bool insertada = false;

        while (!ColaTareas.IsEmpty())
        {
            Tarea actual = ColaTareas.Dequeue();

            if (!insertada && nuevaTarea.Prioridad < actual.Prioridad)
            {
                aux.Enqueue(nuevaTarea);
                insertada = true;
            }

            aux.Enqueue(actual); // 🔥 SIEMPRE se guarda el actual
        }

        if (!insertada)
        {
            aux.Enqueue(nuevaTarea);
        }

        while (!aux.IsEmpty())
        {
            ColaTareas.Enqueue(aux.Dequeue());
        }
    }


    public void ImprimirTarea()
    {
        var aux = new MyQueue<Tarea>();

        while (!ColaTareas.IsEmpty())
        {
            Tarea actual = ColaTareas.Dequeue();

            string linea = $"{actual.Id},{actual.Prioridad},";

            var auxSub = new MyQueue<Subtarea>();
            bool primero = true;

            while (!actual.Subtareas.IsEmpty())
            {
                Subtarea st = actual.Subtareas.Dequeue();

                if (!primero)
                    linea += "|";

                linea += $"{st.Id},{st.Descripcion}";

                primero = false;

                auxSub.Enqueue(st);
            }

            while (!auxSub.IsEmpty())
            {
                actual.Subtareas.Enqueue(auxSub.Dequeue());
            }

            Console.WriteLine(linea);

            aux.Enqueue(actual);
        }

        while (!aux.IsEmpty())
        {
            ColaTareas.Enqueue(aux.Dequeue());
        }
    }
}