namespace Lesson13CustomException;

public class InvalidDataException : Exception
{
    public ExceptionStatusEnum StatusEnum { get; protected set;}

    public InvalidDataException()
    {
    }

    public InvalidDataException(ExceptionStatusEnum statusEnum)
    {
        StatusEnum = statusEnum;
    }

    public InvalidDataException(string? message, ExceptionStatusEnum statusEnum) : base(message)
    {
        StatusEnum = statusEnum;
    }
}