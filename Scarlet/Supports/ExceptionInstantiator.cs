using System;

namespace Scarlet.Supports
{
    public static class ExceptionInstantiator
    {
        public static ArgumentException NullOrWhiteSpaceArgument(string argumentName)
        {
            return new ArgumentException("Value cannot be set to null or white space.", argumentName);
        }

        public static ArgumentException EmptyCollectionArgument(string argumentName)
        {
            return new ArgumentException("Collection argument is empty.", argumentName);
        }
    }
}
