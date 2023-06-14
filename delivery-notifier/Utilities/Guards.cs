using Utilities.Exceptions;

namespace Utilities
{
    public class Guards
    {
        public static void Require(bool expression, string message)
        {
            if (!expression)
            {
                throw new CustomException(message);
            }
        }
    }
}
