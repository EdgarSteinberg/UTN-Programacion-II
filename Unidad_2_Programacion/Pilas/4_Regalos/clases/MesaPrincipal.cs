namespace EstructurasLibrary;

public class MesaPrincipal
{
    private MyStack<Paquete> _mesaPrincipal;
    private MyStack<Paquete> _mesaAuxiliar;

    public MesaPrincipal()
    {
        _mesaPrincipal = new MyStack<Paquete>();
        _mesaAuxiliar = new MyStack<Paquete>();
    }
    public void AgregarPaquete(Paquete p)
    {
        _mesaPrincipal.Push(p);
    }
    public void OrdenarPaquetes()
    {
        MyStack<Paquete> aux = new MyStack<Paquete>();

        while (!_mesaPrincipal.IsEmpty())
        {
            Paquete actual = _mesaPrincipal.Pop();

            while (!aux.IsEmpty())
            {
                Paquete top = aux.Pop();

                if (top.Tamanio > actual.Tamanio)
                {
                    _mesaPrincipal.Push(top);
                }
                else
                {
                    _mesaPrincipal.Push(top);
                    break;
                }
            }

            aux.Push(actual);
        }

        while (!aux.IsEmpty())
        {
            _mesaPrincipal.Push(aux.Pop());
        }
    }


    public void Mostrar()
    {
        var aux = new MyStack<Paquete>();

        while (!_mesaPrincipal.IsEmpty())
        {
            var p = _mesaPrincipal.Pop();
            Console.WriteLine(p.Tamanio);
            aux.Push(p);
        }

        while (!aux.IsEmpty())
        {
            _mesaPrincipal.Push(aux.Pop());
        }
    }
}