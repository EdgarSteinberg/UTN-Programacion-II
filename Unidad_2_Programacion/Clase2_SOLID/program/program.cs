INadador pato = new Pato();
//Pato pato = new Pato();
//pato.Cuack();
//pato.Volar();
//pato.Nadar();

//INadador patoGoma = new PatoGoma();
PatoGoma patoGoma = new PatoGoma();
//patoGoma.Nadar();
//patoGoma.Cuack();

RecibirNadador(pato);
RecibirNadador(patoGoma);


static void RecibirNadador(INadador objNadador)
{
    objNadador.Nadar();
}
