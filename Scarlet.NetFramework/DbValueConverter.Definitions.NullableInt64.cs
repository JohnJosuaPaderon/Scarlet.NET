using System;

namespace Scarlet
{
    partial class DbValueConverter
    {
        public static long? ToNullableInt64(bool value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(byte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(char value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(double value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(short value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(int value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(long value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(float value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(string value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(uint value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }
    }
}
