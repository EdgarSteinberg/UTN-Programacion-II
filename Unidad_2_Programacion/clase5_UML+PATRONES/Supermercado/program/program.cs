using EstructurasLibrary;

Ppersona objPersona = new Ppersona(
    "Edgar",
    new DateTime(1990, 5, 10),
    true
);

Ppersona objPersona1 = new Ppersona(
    "Rube",
    new DateTime(1940, 8, 22),
    false
);

Ppersona objPersona2 = new Ppersona(
    "Artigas",
    new DateTime(1997, 1, 14),
    false
);

Ppersona objPersona3 = new Ppersona(
    "Tony",
    new DateTime(1965, 11, 3),
    false
);

Ppersona objPersona4 = new Ppersona(
    "Bernardo",
    new DateTime(1945, 7, 19),
    true
);

Psupermercado super = new Psupermercado();

super.Recibir(objPersona);
super.Recibir(objPersona1);
super.Recibir(objPersona2);
super.Recibir(objPersona3);
super.Recibir(objPersona4);

super.Atender();