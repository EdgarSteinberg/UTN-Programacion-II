//using EstructurasLibrary;

/* “Modelé el sistema con cuatro entidades principales: Gimnasio, Socio, Actividad y Promoción.
El socio tiene una o varias actividades y puede o no tener pase libre.

Para calcular la cuota usé Strategy, porque el comportamiento cambia según el tipo de socio.
Entonces tengo dos estrategias: una para el cálculo normal, que suma las actividades y aplica la promoción vigente si corresponde, y otra para pase libre, que devuelve un precio fijo sin aplicar descuentos.

La promoción está en el gimnasio como única vigente por mes y se aplica solo si el socio realiza al menos dos actividades incluidas en esa promoción.

De esta forma separo datos de comportamiento y evito lógica mezclada dentro del socio. */

/* class Program
{
    static void Main()
    {
        // =========================
        // GIMNASIO
        // =========================
        Gimnasio gimnasio = new Gimnasio();

        // =========================
        // ACTIVIDADES
        // =========================
        Actividad musculacion = new Actividad(
            "Musculación",
            "Pesas y máquinas",
            30000,
            "Juan Perez",
            "Lunes a Viernes",
            "08:00-22:00"
        );

        Actividad pileta = new Actividad(
            "Pileta",
            "Natación libre",
            25000,
            "Ana Gomez",
            "Lunes a Sábado",
            "09:00-20:00"
        );

        Actividad crossfit = new Actividad(
            "CrossFit",
            "Entrenamiento funcional",
            35000,
            "Carlos Diaz",
            "Martes y Jueves",
            "18:00-21:00"
        );

        gimnasio.AgregarActividad(musculacion);
        gimnasio.AgregarActividad(pileta);
        gimnasio.AgregarActividad(crossfit);

        // =========================
        // SOCIO NORMAL
        // =========================
        Socio socioNormal = new Socio(
            "Pedro",
            "Gomez",
            12345678,
            "Calle 123",
            "pedro@mail.com",
            11223344
        );

        socioNormal.AgregarActividad(musculacion);
        socioNormal.AgregarActividad(pileta);

        socioNormal.SetEstrategia(new CalcularCuotaNormal());

        // =========================
        // SOCIO PASE LIBRE
        // =========================
        Socio socioLibre = new Socio(
            "Laura",
            "Martinez",
            87654321,
            "Calle 456",
            "laura@mail.com",
            99887766
        );

        socioLibre.SetEstrategia(new CalcularPaseLibre());

        // =========================
        // PROMOCIÓN
        // =========================
        Promocion promo = new Promocion("Promo Verano", 10);

        promo.Actividades.Add(musculacion);
        promo.Actividades.Add(pileta);

        gimnasio.PromocionVigente = promo;

        // =========================
        // PRUEBAS
        // =========================
        Console.WriteLine("=== RESULTADOS ===");

        Console.WriteLine("Cuota socio normal: " +
            socioNormal.CalcularCuota(gimnasio));

        Console.WriteLine("Cuota socio libre: " +
            socioLibre.CalcularCuota(gimnasio));
    }
} */