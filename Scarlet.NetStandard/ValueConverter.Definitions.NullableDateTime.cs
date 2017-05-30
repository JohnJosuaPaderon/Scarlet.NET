using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static DateTime? ToNullableDateTime(object value)
        {
            return NullableConversionBase(value, Convert.ToDateTime);
        }

        public static DateTime? ToNullableDateTime(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToDateTime);
        }

        public static DateTime? ToNullableDateTime(string value)
        {
            return NullableConversionBase(value, Convert.ToDateTime);
        }

        public static DateTime? ToNullableDateTime(string value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToDateTime);
        }
    }
}
