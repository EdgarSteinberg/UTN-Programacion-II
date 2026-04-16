using Ejercicios.clases;

class Program
{
    static void Main()
    {
        Micro micro = new Micro(300,10, 5);

        Fiaca fiaca = new Fiaca();   
        micro.Subir(fiaca);

        Claustrofobico claustrofobico = new Claustrofobico();
        micro.Subir(claustrofobico);

        Moderado moderado = new Moderado(5);
        micro.Subir(moderado);

        Obsecuente obsecuente = new Obsecuente(moderado);
        micro.Subir(obsecuente);
        moderado.EsJefe = true;
    }
}