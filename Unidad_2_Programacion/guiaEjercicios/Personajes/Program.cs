using clases;

class Program
{
    static void Main(string[] args)
    {

        // Armas
        Arma espada = new Arma("Espada Larga", 4, TipoAtaque.CORTANTE); // balanceada

        Arma lanza = new Arma("Lanza", 3, TipoAtaque.PERFORANTE); // rápida pero menos daño

        Arma martillo = new Arma("Martillo de guerra", 6, TipoAtaque.APLASTANTE); // lento pero fuerte

        Arma baston = new Arma("Bastón arcano", 5, TipoAtaque.MAGICO); // ignora defensa en algunos casos

        /*  Console.WriteLine($"Arma: {espada.Nombre}");
         Console.WriteLine($"Daño: {espada.Danio}");
         Console.WriteLine($"Tipo: {espada.Tipo}"); */

        //Armadura 

        Armadura bronce = new Armadura("Armadura Bronce", 5, 3, TipoAtaque.PERFORANTE);

        Armadura plata = new Armadura("Armadura Plata", 7, 5, TipoAtaque.CORTANTE);

        Armadura dorada = new Armadura("Armadura Dorada", 9, 8, TipoAtaque.APLASTANTE);

        Armadura magica = new Armadura("Armadura Magica", 10, 10, TipoAtaque.MAGICO);


        //Habiliaddes

        Habilidad infanteria = new Habilidad("Formación de Infantería", 1, 2, TipoHabilidad.DEFENSA);

        Habilidad arquero = new Habilidad("Disparo Preciso", 2, 3, TipoHabilidad.ATAQUE);

        Habilidad caballeria = new Habilidad("Carga de Caballería", 3, 5, TipoHabilidad.ATAQUE);


        //Personaje
        Guerrero guerrero = new Guerrero();
        guerrero.Nombre = "Hercules";
        guerrero.Arma = lanza;
        guerrero.Armadura = bronce;

        guerrero.Habilidades = new List<Habilidad>
        {
             infanteria,
             arquero,
             caballeria
        };
        Console.WriteLine($"Personaje: {guerrero.Nombre}");
        Console.WriteLine($"Arma: {guerrero.Arma.Nombre}");
        Console.WriteLine($"Armadura: {guerrero.Armadura.Nombre}");
        Console.WriteLine($"Vida: {guerrero.PuntosDeVitalidad}");
        guerrero.SubirNivel();

        // Mago
        Mago mago = new Mago();
        mago.Nombre = "Wally";
        mago.Arma = baston;
        mago.Armadura = magica;

        mago.Habilidades = new List<Habilidad>
        {
             infanteria,
             arquero,
             caballeria
        };

        Console.WriteLine($"Personaje: {mago.Nombre}");
        Console.WriteLine($"Arma: {mago.Arma.Nombre}");
        Console.WriteLine($"Armadura: {mago.Armadura.Nombre}");
        Console.WriteLine($"Vida: {mago.PuntosDeVitalidad}");


        Console.WriteLine("⚔️ Hercules vs Wally ⚔️");
        guerrero.Atacar(mago);
        Console.WriteLine($"{mago.Nombre} ahora tiene {mago.PuntosDeVitalidad} de vida");

        mago.Atacar(guerrero);
        Console.WriteLine($"{guerrero.Nombre} ahora tiene {guerrero.PuntosDeVitalidad} de vida");

        guerrero.Atacar(mago);
        Console.WriteLine($"{mago.Nombre} ahora tiene {mago.PuntosDeVitalidad} de vida");

        mago.Atacar(guerrero);
        Console.WriteLine($"{guerrero.Nombre} ahora tiene {guerrero.PuntosDeVitalidad} de vida");

        guerrero.Atacar(mago);
        Console.WriteLine($"{mago.Nombre} ahora tiene {mago.PuntosDeVitalidad} de vida");

        mago.Atacar(guerrero);
        Console.WriteLine($"{guerrero.Nombre} ahora tiene {guerrero.PuntosDeVitalidad} de vida");
         guerrero.Atacar(mago);
        Console.WriteLine($"{mago.Nombre} ahora tiene {mago.PuntosDeVitalidad} de vida");
    
        mago.Atacar(guerrero);
         Console.WriteLine($"{guerrero.Nombre} ahora tiene {guerrero.PuntosDeVitalidad} de vida");
    }
}

