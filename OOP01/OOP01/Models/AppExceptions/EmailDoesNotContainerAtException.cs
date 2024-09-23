namespace OOP01.Models.AppExceptions
{
    [Serializable]
    internal class EmailDoesNotContainerAtException : Exception
    {
        public EmailDoesNotContainerAtException()
        {
        }

        public EmailDoesNotContainerAtException(string? message) : base(message)
        {
        }

        public EmailDoesNotContainerAtException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}