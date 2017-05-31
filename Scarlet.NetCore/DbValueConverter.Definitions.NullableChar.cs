using System;

namespace Scarlet
{
    partial class DbValueConverter
    {
        public static char? ToNullableChar(short value)
        {
            return ConversionBase(value, ValueConverter.ToNullableChar);
        }

        public static char? ToNullableChar(int value)
        {
            return ConversionBase(value, ValueConverter.ToNullableChar);
        }

        public static char? ToNullableChar(long value)
        {
            return ConversionBase(value, ValueConverter.ToNullableChar);
        }

        public static char? ToNullableChar(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableChar);
        }

        public static char? ToNullableChar(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableChar);
        }

        public static char? ToNullableChar(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableChar);
        }

        public static char? ToNullableChar(string value)
        {
            return ConversionBase(value, ValueConverter.ToNullableChar);
        }

        public static char? ToNullableChar(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableChar);
        }

        public static char? ToNullableChar(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToNullableChar);
        }

        public static char? ToNullableChar(uint value)
        {
            return ConversionBase(value, ValueConverter.ToNullableChar);
        }

        public static char? ToNullableChar(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToNullableChar);
        }
    }
}
