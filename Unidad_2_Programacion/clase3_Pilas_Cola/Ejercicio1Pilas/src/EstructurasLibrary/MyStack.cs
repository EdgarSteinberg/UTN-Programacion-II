namespace EstructurasLibrary;

public class MyStack<T>
{
    private MyNode<T> head; // Tope de la pila (cabeza)
    public MyStack()
    {
        head = null; // Pila vacía
    }

    // IsEmpty: verificar si está vacía
    public bool IsEmpty()
    {
        return head == null;
    }

    // push: insertar en el tope
    public virtual void Push(T value)
    {
        var newNode = new MyNode<T>(value);
        newNode.Next = head; // El nuevo nodo apunta al antiguo
        head = newNode; // El nuevo nodo ES el nuevo tope
    }

    // Pop: extraer del tope (DESTRUCTIVO)
    public virtual T Pop()
    {
        if (IsEmpty())
        {
            return default; // devuelve null para referencias o valor por defecto para tipos primitivos
        }
        T value = head.Value;
        head = head.Next; // El tope pasa a ser el siguiente 
        return value;
    }

}