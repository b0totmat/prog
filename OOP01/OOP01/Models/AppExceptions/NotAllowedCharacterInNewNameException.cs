namespace OOP01.Models.AppExceptions
{
    [Serializable]
    internal class NotAllowedCharacterInNewNameException : Exception
    {
        public NotAllowedCharacterInNewNameException()
        {
        }

        public NotAllowedCharacterInNewNameException(string? message) : base(message)
        {
        }

        public NotAllowedCharacterInNewNameException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}