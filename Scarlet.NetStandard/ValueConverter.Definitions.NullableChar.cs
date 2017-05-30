using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static char? ToNullableChar(short value)
        {
            return NullableConversionBase(value, Convert.ToChar);
        }

        public static char? ToNullableChar(int value)
        {
            return NullableConversionBase(value, Convert.ToChar);
        }

        public static char? ToNullableChar(long value)
        {
            return NullableConversionBase(value, Convert.ToChar);
        }

        public static char? ToNullableChar(object value)
        {
            return NullableConversionBase(value, Convert.ToChar);
        }

        public static char? ToNullableChar(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToChar);
        }

        public static char? ToNullableChar(sbyte value)
        {
            return NullableConversionBase(value, Convert.ToChar);
        }

        public static char? ToNullableChar(string value)
        {
            return NullableConversionBase(value, Convert.ToChar);
        }

        public static char? ToNullableChar(string value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToChar);
        }

        public static char? ToNullableChar(ushort value)
        {
            return NullableConversionBase(value, Convert.ToChar);
        }

        public static char? ToNullableChar(uint value)
        {
            return NullableConversionBase(value, Convert.ToChar);
        }

        public static char? ToNullableChar(ulong value)
        {
            return NullableConversionBase(value, Convert.ToChar);
        }
    }
}
