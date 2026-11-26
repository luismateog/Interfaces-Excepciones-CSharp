namespace RetoExcepciones;

public sealed class EdadInvalidaException : Exception
{
    public EdadInvalidaException(string message) : base(message) { }
}
