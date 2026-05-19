namespace EstructurasLibrary;

 
public class Editor
{
    private MyStack<Accion> undoStack;
    private MyStack<Accion> redoStack;

    public Editor()
    {
        undoStack = new MyStack<Accion>();
        redoStack = new MyStack<Accion>();
    }

    public void EjecutarAccion(Accion accion)
    {
        accion.Ejecutar();
        undoStack.Push(accion);
        redoStack = new MyStack<Accion>();
    }

    public void Deshacer()
    {
        if (undoStack.IsEmpty())
            return;

        Accion accion = undoStack.Pop();
        accion.Deshacer();
        redoStack.Push(accion);
    }

    public void Rehacer()
    {
        if (redoStack.IsEmpty())
            return;

        Accion accion = redoStack.Pop();
        accion.Ejecutar();
        undoStack.Push(accion);
    }
}