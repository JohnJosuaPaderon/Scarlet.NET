namespace Scarlet.Core
{
    public static class Configuration
    {
        private static readonly char Default_PersonMiddleNameSeparator = ' ';
        private static readonly string Default_SystemModuleCodeSeriesFormat = "0000";

        private static char _PersonMiddleNameSeparator;
        private static string _SystemModuleCodeSeriesFormat;

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

        public static string SystemModuleCodeSeriesFormat
        {
            get { return _SystemModuleCodeSeriesFormat; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _SystemModuleCodeSeriesFormat = Default_SystemModuleCodeSeriesFormat;
                }
                else
                {
                    _SystemModuleCodeSeriesFormat = value.Trim();
                }
            }
        }
    }
}
