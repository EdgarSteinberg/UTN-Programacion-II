 class Scanner
{
    public Objeto Escanear(string material, double volumen, bool estaContenido, List<Objeto> contenido)
    {
        return new Objeto
        {
            Material = material,
            Volumen = volumen,
            EstaContenido = estaContenido,
            Contenido = contenido
        };
    }
}

public class Objeto
{
    public string Material { get; set; }
    public double Volumen { get; set; }
    public List<Objeto> Contenido { get; set; } = new List<Objeto>();
    public bool EstaContenido { get; set; }

    public string Tipo()
    {
        if (Contenido.Count == 0 && !EstaContenido)
            return "Simple";

        if (Contenido.Count > 0 && !EstaContenido)
            return "Contenedor";

        if (Contenido.Count == 0 && EstaContenido)
            return "Contenido";

        return "Sambuchito";
    }

    public void Mostrar()
    {
        Console.WriteLine("-----------");
        Console.WriteLine($"Material: {Material}");
        Console.WriteLine($"Volumen: {Volumen}");
        Console.WriteLine($"Cantidad de objetos dentro: {Contenido.Count}");
        Console.WriteLine($"Está contenido: {EstaContenido}");
        Console.WriteLine($"Tipo: {Tipo()}");
    }
}

class Program
{
    static void Main()
    {
        Scanner scanner = new Scanner();

        // 1️⃣ Mamushka de madera de varios niveles
        Objeto mamushka1 = scanner.Escanear("madera", 300, false, new List<Objeto>());
        Objeto mamushka2 = scanner.Escanear("madera", 200, true, new List<Objeto>());
        Objeto mamushka3 = scanner.Escanear("madera", 100, true, new List<Objeto>());

        mamushka2.Contenido.Add(mamushka3);
        mamushka1.Contenido.Add(mamushka2);

        // 2️⃣ Portafolios vacío de cuero
        Objeto portafolio = scanner.Escanear("cuero", 500, false, new List<Objeto>());

        // 3️⃣ Botiquín con gasa y agua oxigenada
        Objeto gasa = scanner.Escanear("textil", 10, true, new List<Objeto>());
        Objeto aguaOxigenada = scanner.Escanear("liquido", 20, true, new List<Objeto>());

        Objeto botiquin = scanner.Escanear("plastico", 150, false, new List<Objeto>());
        botiquin.Contenido.Add(gasa);
        botiquin.Contenido.Add(aguaOxigenada);

        // 4️⃣ Bolsa de cuero con peine y botiquín
        Objeto peine = scanner.Escanear("plastico", 5, true, new List<Objeto>());

        Objeto bolsa = scanner.Escanear("cuero", 300, false, new List<Objeto>());
        bolsa.Contenido.Add(peine);
        bolsa.Contenido.Add(botiquin);

        // Mostrar resultados
        Console.WriteLine("Mamushka externa:");
        mamushka1.Mostrar();

        Console.WriteLine("Mamushka interna:");
        mamushka2.Mostrar();

        Console.WriteLine("Mamushka más chica:");
        mamushka3.Mostrar();

        Console.WriteLine("Portafolio:");
        portafolio.Mostrar();

        Console.WriteLine("Botiquín:");
        botiquin.Mostrar();

        Console.WriteLine("Bolsa:");
        bolsa.Mostrar();
    }
}