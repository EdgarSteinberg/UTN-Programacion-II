namespace EstructurasLibrary;
/* 3. Decorator base
Acá está el famoso "wrapper". */

public abstract class BaseDecorator : INotifier
{
    protected INotifier _notifier;

    public BaseDecorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    public virtual void Send(string message)
    {
        _notifier.Send(message);
    }
}