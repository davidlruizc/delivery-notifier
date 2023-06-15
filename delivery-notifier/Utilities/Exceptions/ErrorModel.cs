namespace Utilities.Exceptions
{
    public class ErrorModel
    {
        public string Message { get; set; }
        private ErrorModel(string message)
        {
            Message = message;
        }

        public static ErrorModel Of(string message) => new ErrorModel(message);
    }
}
