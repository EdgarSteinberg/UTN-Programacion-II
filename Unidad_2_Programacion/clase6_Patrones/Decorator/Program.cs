

using  ConsoleLibrary;


//Ejemplo de Template Method
// Informe objInforme = new InformeCSV();
// objInforme.GenerarInformeTemplateMethod();

// objInforme = new InformePDF();
// objInforme.GenerarInformeTemplateMethod();


//Fin de ejemplo de Template Method


//Inicio de Decorator
Bebida objCafecito;
objCafecito = new Cafe();
objCafecito = new Leche(objCafecito);
objCafecito = new Azucar(objCafecito);

Console.WriteLine("Descripción: " + objCafecito.Descripcion + " Costo: " + objCafecito.Costo());
