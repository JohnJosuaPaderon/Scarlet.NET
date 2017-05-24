using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static bool? ToNullableBoolean(bool value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(byte value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(decimal value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(double value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(short value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(int value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(long value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(object value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(sbyte value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(float value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(string value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(string value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(ushort value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(uint value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(ulong value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }
    }
}
