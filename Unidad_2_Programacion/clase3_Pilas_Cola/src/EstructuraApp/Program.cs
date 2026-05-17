/*
dotnet new sln -n ConsoleSolution

dotnet new console -n ConsoleApp -o src/ConsoleApp
dotnet sln add src/ConsoleApp/ConsoleApp.csproj

dotnet new classlib -n ConsoleLibrary -o src/ConsoleLibrary
dotnet sln add src/ConsoleLibrary/ConsoleLibrary.csproj

dotnet add src/ConsoleApp/ConsoleApp.csproj reference src/ConsoleLibrary/ConsoleLibrary.csproj
 */

using EstructurasLibrary;

var miPila = new MyStack<int>(); //Head -> null


miPila.Push(1); // Head -> [1 | ]-> null
miPila.Push(2); // Head -> [2 | ]-> [1 | ] => null
miPila.Push(3);

Console.WriteLine(miPila.Pop());
Console.WriteLine(miPila.Pop());
Console.WriteLine(miPila.Pop());

var miCola = new MyQueue<int>();

miCola.Enqueue(1);
miCola.Enqueue(2);
miCola.Enqueue(3);

Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());