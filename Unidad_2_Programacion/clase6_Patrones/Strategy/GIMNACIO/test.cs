/* using EstructurasLibrary;


GimnacioIndioSolari indioSolari = new GimnacioIndioSolari("Indio Solari Gim");

CalcularCuotaSocioStrategy calcularCuota = new CuotaPuraGimnacioStrategy();

PromocionGimnacio promoRicota = new PromocionGimnacio("PromoRicota", 0.20);

SocioGim socioSkay =
    new SocioGim(
        "Skay",
        "Beilinson",
        "Musico",
        false,
        calcularCuota);

ActivdadesGimancio pileta =
    new ActivdadesGimancio("Pileta", "...", 100, "...", 2, 18);

ActivdadesGimancio crossfit =
    new ActivdadesGimancio("Crossfit", "...", 150, "...", 3, 20);

ActivdadesGimancio zumba =
    new ActivdadesGimancio("Zumba", "...", 200, "...", 4, 19);

promoRicota.AgregarActividad(pileta);
promoRicota.AgregarActividad(crossfit);


indioSolari.AgregarPromocion(promoRicota);
indioSolari.AgregarSocio(socioSkay);

socioSkay.AgregarActividad(pileta);
socioSkay.AgregarActividad(crossfit);

promoRicota.AplicaPromocion(socioSkay);
double cuota = socioSkay.CalcularCuota();


cuota = promoRicota.AplicarDescuento(socioSkay, cuota);

Console.WriteLine($"Cuota: {cuota}");


// Ahora creamos un socio que solo hace pileta: 

CalcularCuotaSocioStrategy calcularCuota2 = new CuotaPuraGimnacioStrategy();

SocioGim socioWalter =
    new SocioGim(
        "Walter",
        "Giardino",
        "Guitarrista",
        false,
        calcularCuota2);

socioWalter.AgregarActividad(pileta);

double cuotaNormal = socioWalter.CalcularCuota();

cuotaNormal = promoRicota.AplicarDescuento(socioWalter, cuotaNormal);

Console.WriteLine(
    $"Cuota: {cuotaNormal} socio: {socioWalter.Nombre} - actividades: {socioWalter.MostrarActividades()}"); */


