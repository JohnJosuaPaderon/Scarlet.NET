using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static long? ToNullableInt64(bool value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(byte value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(char value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(decimal value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(double value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(short value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(int value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(long value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(object value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToInt64);
        }

        public static long? ToNullableInt64(sbyte value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(float value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(string value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(string value, int fromBase)
        {
            return NullableConversionBase(value, fromBase, Convert.ToInt64);
        }

        public static long? ToNullableInt64(string value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToInt64);
        }

        public static long? ToNullableInt64(ushort value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(uint value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(ulong value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }
    }
}
