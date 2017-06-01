using System;

namespace Scarlet
{
    partial class DbValueConverter
    {
        public static bool? ToNullableBoolean(bool value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(byte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(double value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(short value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(int value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(long value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(float value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(string value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(uint value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }
    }
}
