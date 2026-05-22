MyList<int> myList = new MyList<int>();
myList.Push(1);
//myList.Push(2);
myList.Push(3);

myList.InsertUnique(2);
Console.WriteLine("Despues de intentar insertar un valor duplicado:");
myList.Print();

Console.WriteLine("Despues de intentar insertar un valor 4:");

myList.InsertUnique(4);

myList.Print();

Console.WriteLine("Nueva Lista String");

MyList<string> myList1 = new MyList<string>();
myList1.InsertUnique("Andres");
myList1.InsertUnique("Charly");
myList1.InsertUnique("Mario");

var busqueda = myList1.Search("Mario");
Console.WriteLine($"Encontre a: " + busqueda.Value);

myList1.InsertUnique("Leonardo");
myList1.Print();
