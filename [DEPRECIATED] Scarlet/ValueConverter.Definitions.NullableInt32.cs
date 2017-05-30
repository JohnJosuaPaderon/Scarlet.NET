using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static int? ToNullableInt32(bool value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(byte value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(char value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(decimal value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(double value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(short value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(int value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(long value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(object value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToInt32);
        }

        public static int? ToNullableInt32(sbyte value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(float value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(string value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(string value, int fromBase)
        {
            return NullableConversionBase(value, fromBase, Convert.ToInt32);
        }

        public static int? ToNullableInt32(string value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToInt32);
        }

        public static int? ToNullableInt32(ushort value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(uint value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(ulong value)
        {
            return NullableConversionBase(value, Convert.ToInt32);
        }
    }
}
