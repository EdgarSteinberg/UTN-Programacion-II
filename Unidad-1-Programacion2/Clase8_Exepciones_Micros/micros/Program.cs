using Clase8_Exepciones_Micros.clases;

class Program
{
    static void Main(string[] args)
    {
        Micro objMicro1 = new Micro();

        objMicro1.Sentados = 20;
        objMicro1.Parados = 10;
        objMicro1.Volumen = 150;

        Persona apurado = new Apurado();
        Persona claustrofobico = new claustrofobico();
        Persona fiaca = new Fiaca();
        Persona moderado = new Moderado();
        Persona obsecuente = new Obsecuente();

        Persona jefe = new Apurado();
        obsecuente.Jefe = jefe;

        Console.WriteLine($"Es jefe? {jefe.EsJefe}");
        Console.WriteLine($"Puede subir apurado? {objMicro1.PuedeSubir(apurado)}");
        Console.WriteLine($"Puede subir obsecuente? {objMicro1.PuedeSubir(obsecuente)}");

        objMicro1.Subir(apurado);
        objMicro1.Subir(fiaca);

        Console.WriteLine("Subieron personas");

        objMicro1.Bajar(fiaca);

        Console.WriteLine($"Primero que subió: {objMicro1.SubioPrimero()}");
    }
}