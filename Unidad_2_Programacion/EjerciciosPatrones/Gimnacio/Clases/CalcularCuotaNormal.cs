namespace EstructurasLibrary;

public class CalcularCuotaNormal : ICalcularCuota
{   
    
    public decimal Costo(Socio s, Gimnasio g)
    {
        decimal total = 0;

        foreach (Actividad a in s.Actividades)
        {
            total += a.PrecioMensual;
        }

        Promocion promo = g.PromocionVigente;

        if (promo != null && promo.Aplica(s))
        {
            total -= promo.CalcularDescuento(total);
        }

        return total;
    }
}