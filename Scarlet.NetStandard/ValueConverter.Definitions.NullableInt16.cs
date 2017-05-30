using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static short? ToNullableInt16(bool value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(byte value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(char value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(decimal value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(double value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(short value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(int value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(long value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(object value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToInt16);
        }

        public static short? ToNullableInt16(sbyte value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(float value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(string value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(string value, int fromBase)
        {
            return NullableConversionBase(value, fromBase, Convert.ToInt16);
        }

        public static short? ToNullableInt16(string value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToInt16);
        }

        public static short? ToNullableInt16(ushort value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(uint value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(ulong value)
        {
            return NullableConversionBase(value, Convert.ToInt16);
        }
    }
}
