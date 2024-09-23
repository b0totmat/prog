namespace OOP01.Models.AppExceptions
{
    [Serializable]
    internal class NewEmailEqualsToOldOneException : Exception
    {
        public NewEmailEqualsToOldOneException()
        {
        }

        public NewEmailEqualsToOldOneException(string? message) : base(message)
        {
        }

        public NewEmailEqualsToOldOneException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}