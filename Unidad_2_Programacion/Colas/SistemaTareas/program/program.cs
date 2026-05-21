using EstructurasLibrary;

Tarea tarea1 = new Tarea(1, 1);
Tarea tarea2 = new Tarea(2, 2);
Tarea tarea3 = new Tarea(3, 3);

// Subtareas
Subtarea subtarea1 = new Subtarea(1, "Estas mejorando!");
Subtarea subtarea2 = new Subtarea(2, "Falta Poco para tu oportunidad");
Subtarea subtarea3 = new Subtarea(3, "Lo vas a lograr!");
Subtarea subtarea4 = new Subtarea(4, "Sigue asi!");

// 🔥 asignación de subtareas a tareas
tarea1.AgregarSubtarea(subtarea1);
tarea1.AgregarSubtarea(subtarea2);

tarea2.AgregarSubtarea(subtarea3);

tarea3.AgregarSubtarea(subtarea4); // 👈 ahora ya no queda en 0

// Sistema
SistemaTarea sistemaTarea = new SistemaTarea();

// Agregar tareas al sistema
sistemaTarea.AgregarTarea(tarea1);
sistemaTarea.AgregarTarea(tarea2);
sistemaTarea.AgregarTarea(tarea3);

// Imprimir
sistemaTarea.ImprimirTarea();