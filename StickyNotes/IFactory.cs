namespace StickyNotes
{
    public interface IFactory<E>
    {
        E Create<T>() where T : E, new();
    }
}