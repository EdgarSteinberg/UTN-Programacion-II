using EstructurasLibrary;

FabricaAbstracta fabrica;
Silla silla; 
Mesa mesa;

//fabrica = new FabricaVictoriana();
fabrica = new FabriacaEscandinavo();
silla = fabrica.CrearSilla();
mesa = fabrica.CrearMesa();

Console.WriteLine("Imprimo losdatos de la silla y la mesa creadas pro la fabrica");
Console.WriteLine(silla.Estilo);
Console.WriteLine(mesa.Estilo);
