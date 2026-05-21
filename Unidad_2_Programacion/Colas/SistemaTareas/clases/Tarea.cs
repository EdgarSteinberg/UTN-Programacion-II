namespace EstructurasLibrary;

public class Tarea
{
    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    private int _prioridad;
    public int Prioridad
    {
        get { return _prioridad; }
        set { _prioridad = value; }
    }

    private MyQueue<Subtarea> _subtareas;

    public MyQueue<Subtarea> Subtareas
    {
        get { return _subtareas; }
        set { _subtareas = value; }
    }

    public Tarea(int id, int prioridad)
    {
        Id = id;
        Prioridad = prioridad;
        _subtareas = new MyQueue<Subtarea>();
    }

    public void AgregarSubtarea(Subtarea st)
    {
        _subtareas.Enqueue(st);
    }

    public int CantidadSubtareas
    {
        get
        {
            int count = 0;
            var aux = new MyQueue<Subtarea>();

            while (!_subtareas.IsEmpty())
            {
                aux.Enqueue(_subtareas.Dequeue());
                count++;
            }

            while (!aux.IsEmpty())
            {
                _subtareas.Enqueue(aux.Dequeue());
            }

            return count;
        }
    }
}