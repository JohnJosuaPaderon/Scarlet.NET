using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static DateTime ToDateTime(object value)
        {
            return ConversionBase(value, Convert.ToDateTime);
        }

        public static DateTime ToDateTime(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToDateTime);
        }

        public static DateTime ToDateTime(string value)
        {
            return ConversionBase(value, Convert.ToDateTime);
        }

        public static DateTime ToDateTime(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToDateTime);
        }
    }
}
