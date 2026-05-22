namespace EstructurasLibrary;

public class MyList<T> where T : notnull, IComparable<T>
{
    private MyNode<T>? head;
    public MyList()
    {
        head = null;
    }

    public MyNode<T> Push(T value)
    {
        var node = new MyNode<T>(value);
        if (head == null)
        {
            head = node;
        }
        else
        {
            var headAux = head;
            while (headAux.Next != null)
            {
                headAux = headAux.Next;
            }
            headAux.Next = node;
        }
        return node;
    }

    public T? Pop()
    {
        if (head == null) return default;
        MyNode<T> headAux = head;
        MyNode<T>? previous = null;
        while (headAux.Next != null)
        {
            previous = headAux;
            headAux = headAux.Next;
        }
        if (previous == null)
        {
            head = null;
        }
        else
        {
            previous.Next = null;
        }
        return headAux.Value;
    }
    public MyNode<T> InsertFirst(T value)
    {
        var node = new MyNode<T>(value);
        node.Next = head;
        head = node;
        return node;
    }

    public T? RemoveFirst()
    {
        if (head == null) return default;
        T value = head.Value;
        head = head.Next;
        return value;
    }

    public MyNode<T> InsertOrdered(T value)
    {
        var node = new MyNode<T>(value);
        MyNode<T>? headAux = head;
        MyNode<T>? previous = null;
        while (headAux != null && headAux.Value.CompareTo(value) < 0)
        {
            previous = headAux;
            headAux = headAux.Next;
        }
        if (previous == null)
        {
            head = node;
        }
        else
        {
            previous.Next = node;
        }
        node.Next = headAux;
        return node;
    }
    public MyNode<T> InsertUnique(T value)
    {
        var node = Search(value);
        if (node == null)
        {
            return InsertOrdered(value);
        }
        return node;
    }

    public T? Delete(T value)
    {
        MyNode<T>? headAux = head;
        MyNode<T>? previous = null;
        while (headAux != null && !headAux.Value.Equals(value))
        {
            previous = headAux;
            headAux = headAux.Next;
        }
        if (headAux == null) return default;
        if (previous == null)
        {
            head = headAux.Next;
        }
        else
        {
            previous.Next = headAux.Next;
        }
        return headAux.Value;
    }
    public MyNode<T>? Search(T value)
    {
        MyNode<T>? headAux = head;
        while (headAux != null && !headAux.Value.Equals(value))
        {
            headAux = headAux.Next;
        }
        return headAux;
    }

    public void Sort()
    {
        var listAux = new MyList<T>();
        while (head != null)
        {
            T value = head.Value;
            RemoveFirst();
            listAux.InsertOrdered(value);
        }
        head = listAux.head;
        listAux.Clear();
    }

    public void Print()
    {
        MyNode<T>? headAux = head;
        while (headAux != null)
        {
            Console.WriteLine(headAux.Value);
            headAux = headAux.Next;
        }
    }

    public void Clear()
    {
        while (head != null)
        {
            RemoveFirst();
        }
    }
}
