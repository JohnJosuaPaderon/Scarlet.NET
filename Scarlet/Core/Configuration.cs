namespace Scarlet.Core
{
    public static class Configuration
    {
        private static readonly char Default_PersonMiddleNameSeparator = ' ';

        private static char _PersonMiddleNameSeparator;
        
        public static char PersonMiddleNameSeparator
        {
            get { return _PersonMiddleNameSeparator; }
            set
            {
                if (value == '\0')
                {
                    _PersonMiddleNameSeparator = Default_PersonMiddleNameSeparator;
                }
                else
                {
                    _PersonMiddleNameSeparator = value;
                }
            }
        }
    }
}
