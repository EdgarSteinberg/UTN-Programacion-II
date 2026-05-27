using EstructurasLibrary;

Carpeta carpetaPrincipal = new Carpeta("Disco C", 7);


AnalizadorDeElementos(carpetaPrincipal);

Archivo unArchivoPesado = new Archivo("El Retorno del Rey.mp4", 2048);
AnalizadorDeElementos(unArchivoPesado);

Archivo unArchivoLiviano = new Archivo("misContrasenas.txt", 10);
AnalizadorDeElementos(unArchivoLiviano);

carpetaPrincipal.Agregar(unArchivoPesado);
carpetaPrincipal.Agregar(unArchivoLiviano);

Carpeta otraCarpeta = new Carpeta("Documentos", 10);
Archivo miCv = new Archivo("Mi Cv", 500);
otraCarpeta.Agregar(miCv);
AnalizadorDeElementos(miCv);


Console.WriteLine("Imprimo el contenido de la carpeta principal sin la otra carpeta (Carpeta Documentos)");
AnalizadorDeElementos(carpetaPrincipal);
AnalizadorDeElementos(otraCarpeta);

carpetaPrincipal.Agregar(otraCarpeta);
Console.WriteLine("Imprimo el contenido de la carpeta principal (DISCO C) con la carpeta (Carpeta Documentos)");

AnalizadorDeElementos(carpetaPrincipal);


void AnalizadorDeElementos(Elemento unElemento)
{
    Console.WriteLine($"El elemento {unElemento.Nombre}, pesa {unElemento.DevolverTamano()} MB");
}
