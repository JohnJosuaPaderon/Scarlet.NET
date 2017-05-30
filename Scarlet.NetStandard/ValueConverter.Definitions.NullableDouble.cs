using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static double? ToNullableDouble(bool value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(byte value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(decimal value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(double value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(short value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(int value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(long value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(object value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToDouble);
        }

        public static double? ToNullableDouble(sbyte value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(float value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(string value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(string value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToDouble);
        }

        public static double? ToNullableDouble(ushort value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(uint value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(ulong value)
        {
            return NullableConversionBase(value, Convert.ToDouble);
        }
    }
}
