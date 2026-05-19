

Editor editor = new Editor();

Accion escribir = new RedactarAccion();
Accion imagen = new InsertarImagen();
Accion subrayar = new SubrayarAccion();


Console.WriteLine("== EJECUTAR ACCIONES ==");

editor.EjecutarAccion(escribir);
editor.EjecutarAccion(imagen);
editor.EjecutarAccion(subrayar);

Console.WriteLine("\n== DESHACER ==");

editor.Deshacer();
editor.Deshacer();

Console.WriteLine("\n== REHACER ==");
editor.Rehacer();

editor.Rehacer();

Console.WriteLine("\n== MoverImagen ==");
Accion mover = new MoverImagenAccion("izquierda", "derecha");
editor.EjecutarAccion(mover);