/* using EstructurasLibrary;

Hospital hospital1 = new Hospital(
    "Hospital Dr. Bernardo Houssay",
    "Vicente López",
    4,
    2
);

Hospital hospital2 = new Hospital(
    "Hospital Italiano",
    "Almagro",
    2,
    4
);

UAP uap1 = new UAP(
    "UAP Norte",
    "Centro",
    5
);

UA unidadAdministrativa = new UA(
    "Administración",
    "Centro"
);

unidadAdministrativa.AgregarBase(hospital1);
unidadAdministrativa.AgregarBase(hospital2);
unidadAdministrativa.AgregarBase(uap1);

Console.WriteLine("=== HOSPITALES ===");
Console.WriteLine(
    $"{hospital1.Nombre} | Ambulancias: {hospital1.ObtenerCantidadAmbulancias()} | Tiempo Medio: {hospital1.ObtenerTiempoMedioAsistencia()} | Dirección: {hospital1.Direccion}"
);

Console.WriteLine(
    $"{hospital2.Nombre} | Ambulancias: {hospital2.ObtenerCantidadAmbulancias()} | Tiempo Medio: {hospital2.ObtenerTiempoMedioAsistencia()} | Dirección: {hospital2.Direccion}"
);

Console.WriteLine();

Console.WriteLine("=== UAP ===");
Console.WriteLine(
    $"{uap1.Nombre} | Ambulancias: {uap1.ObtenerCantidadAmbulancias()} | Tiempo Medio: {uap1.ObtenerTiempoMedioAsistencia()} | Dirección: {uap1.Direccion}"
);

Console.WriteLine();

Console.WriteLine("=== UA ===");
Console.WriteLine(
    $"{unidadAdministrativa.Nombre} | Ambulancias Totales: {unidadAdministrativa.ObtenerCantidadAmbulancias()} | Tiempo Medio General: {unidadAdministrativa.ObtenerTiempoMedioAsistencia()} | Dirección: {unidadAdministrativa.Direccion}"
); */