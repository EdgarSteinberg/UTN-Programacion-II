namespace EstructurasLibrary;
public class MyNode<T>
{
    public T Value { get; } // El dato que guarda
    public MyNode<T> Next { get; set; } // Puntero al siguiente nodo
    public MyNode(T value)
    {
        Value = value;
        Next = null; // Empieza sin apuntar a nadie
    }
}
