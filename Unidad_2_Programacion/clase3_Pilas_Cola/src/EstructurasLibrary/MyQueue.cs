namespace EstructurasLibrary;

public class MyQueue<T>
{
    private MyNode<T> first;  // Frente de la cola (se extrae aquí)
    private MyNode<T> last;   // Final de la cola (se inserta aquí)

    public MyQueue()
    {
        first = null;
        last = null;
    }

    public bool IsEmpty()
    {
        return first == null && last == null;
    }

    // enqueue: agregar al final
    public void Enqueue(T value)
    {
        var newNode = new MyNode<T>(value);

        if (IsEmpty())
        {
            first = newNode;  // Si está vacía, es el primero Y el último
        }
        else
        {
            last.Next = newNode;  // El último actual apunta al nuevo
        }

        last = newNode;  // Siempre el nuevo es el último
    }

    // dequeue: sacar del frente (DESTRUCTIVO)
    public T Dequeue()
    {
        if (IsEmpty())
            return default;

        T value = first.Value;
        first = first.Next;   // El frente pasa a ser el siguiente

        if (first == null)    // Si la cola quedó vacía...
            last = null;      // ...también actualizamos last

        return value;
    }
}