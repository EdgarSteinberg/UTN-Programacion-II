using Ejercicios.clases;

Persona padre = new Persona("Juan", "Perez", 1970);

Persona hijo1 = new Persona("Pedro", "Perez", 1995);
Persona hija1 = new Persona("Ana", "Perez", 1998);

padre.AgregarHijo(hijo1);
padre.AgregarHijo(hija1);


ArbolGenialogico arbol = new ArbolGenialogico();
arbol.Raiz = padre;

arbol.Mostrar();