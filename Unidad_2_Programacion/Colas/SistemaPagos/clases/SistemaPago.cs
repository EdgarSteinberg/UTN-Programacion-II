namespace EstructurasLibrary;

public class SistemaPago
{
    private MyQueue<Cliente> _fila1;
    private MyQueue<Cliente> _fila2;

    private int _cantidadFila1;
    public int CantidadFila1
    {
        get { return _cantidadFila1; }
        set { _cantidadFila1 = value; }
    }

    private int _cantidadFila2;
    public int CantidadFila2
    {
        get { return _cantidadFila2; }
        set { _cantidadFila2 = value; }
    }

    public SistemaPago()
    {
        _fila1 = new MyQueue<Cliente>();
        _fila2 = new MyQueue<Cliente>();
    }


    public void AgregarCliente(Cliente nuevo)
    {
        _fila1.Enqueue(nuevo);
        CantidadFila1++;

        if (CantidadFila1 == 10)
        {
            DividirFila();
        }
    }

    private void DividirFila()
    {
        // La fila1 tiene 10 personas
        // Los primeros 5 quedan
        // Los últimos 5 pasan a fila2

        for (int i = 0; i < 10; i++)
        {
            Cliente actual = _fila1.Dequeue();

            // Primera mitad
            if (i < 5)
            {
                _fila1.Enqueue(actual);
            }
            // Segunda mitad
            else
            {
                _fila2.Enqueue(actual);

                // actualizamos contador fila2
                CantidadFila2++;
            }
        }

        // fila1 ahora quedó con 5
        CantidadFila1 = 5;
    }

    public void ImprimirFilas()
    {
        var auxFila1 = new MyQueue<Cliente>();
        var auxFila2 = new MyQueue<Cliente>();

        Console.WriteLine("FILA 1");
        while (!_fila1.IsEmpty())
        {
            Cliente cliente = _fila1.Dequeue();

            Console.WriteLine($"{cliente.Nombre}");

            auxFila1.Enqueue(cliente);
        }
        Console.WriteLine("FILA 2");
        while (!_fila2.IsEmpty())
        {
            Cliente cliente = _fila2.Dequeue();

            Console.WriteLine($"{cliente.Nombre}");

            auxFila2.Enqueue(cliente);
        }

        // Armo de nuevo las filas

        while (!auxFila1.IsEmpty())
        {
            _fila1.Enqueue(auxFila1.Dequeue());
        }

        while (!auxFila2.IsEmpty())
        {
            _fila2.Enqueue(auxFila2.Dequeue());
        }
    }
}