//Cartas
Carta cart1 = new Carta("Edgar", "Sebastian", "Hola Como estas?");
Carta cart2 = new Carta("Sebastian", "Edgar", "bien y vos?");
Carta cart3 = new Carta("Martin", "Leandro", "Hola como va?");
Carta cart4 = new Carta("Leandro", "Martin", "Hola very good?");
Carta cart5 = new Carta("Julio", "Ramona", "hello, how are you?");

//Bandeja
Bandeja bandeja = new Bandeja();

// Apilar cartas
bandeja.Push(cart1);
bandeja.Push(cart2);
bandeja.Push(cart3);
bandeja.Push(cart4);
bandeja.Push(cart5);

var despachadas = bandeja.DespacharPorHora(15);
bandeja.ImprimirCartas(despachadas);
