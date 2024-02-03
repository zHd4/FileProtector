namespace FileProtector.Exceptions
{
    public class PathNotFoundException : Exception
    {
        public PathNotFoundException(string message) : base(message) { }
    }
}
