namespace EstructurasLibrary;

public class Bandeja : MyStack<Carta>
{
    public override void Push(Carta value)
    {
        if (value == null) return;

        base.Push(value);
    }

    public List<Carta> DespacharPorHora(int hora)
    {
        var resultado = new List<Carta>();

        if (this.IsEmpty())
        {
            Console.WriteLine("No hay cartas para despachar.");
            return resultado;
        }

        int cantidad = 0;

        switch (hora)
        {
            case 14:
                cantidad = 10;
                break;

            case 15:
                int total = Contar();
                if (total >= 20)
                    cantidad = total / 2;
                else
                    cantidad = 5;
                break;

            case 16:
                int restantes = Contar();
                cantidad = restantes - 5;
                if (cantidad < 0) cantidad = 0;
                break;

            case 17:
                cantidad = Contar();
                break;

            default:
                Console.WriteLine("Hora no válida.");
                return resultado;
        }

        for (int i = 0; i < cantidad && !this.IsEmpty(); i++)
        {
            resultado.Add(this.Pop());
        }

        return resultado;
    }

    private int Contar()
    {
        var aux = new Bandeja();
        int count = 0;

        while (!this.IsEmpty())
        {
            var carta = this.Pop();
            aux.Push(carta);
            count++;
        }

        while (!aux.IsEmpty())
        {
            this.Push(aux.Pop());
        }

        return count;
    }


    public void ImprimirCartas(List<Carta> cartas)
    {
        foreach (var carta in cartas)
        {
            Console.WriteLine($"{carta.Remitente} -> {carta.Destinatario}");
        }
    }
}