using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static float? ToNullableSingle(bool value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(byte value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(decimal value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(double value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(short value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(int value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(long value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(object value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToSingle);
        }

        public static float? ToNullableSingle(sbyte value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(float value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(string value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(string value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToSingle);
        }

        public static float? ToNullableSingle(ushort value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(uint value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(ulong value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }
    }
}
