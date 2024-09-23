namespace OOP01.Models.AppExceptions
{
    [Serializable]
    public class LastGradeModificationErrorException : ArgumentException
    {
        public LastGradeModificationErrorException()
        {
        }

        public LastGradeModificationErrorException(string? message) : base(message)
        {
        }

        public LastGradeModificationErrorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}