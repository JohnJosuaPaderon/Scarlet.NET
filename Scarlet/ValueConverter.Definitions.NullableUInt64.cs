using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static ulong? ToNullableUInt64(bool value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(byte value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(char value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(decimal value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(double value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(short value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(int value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(long value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(object value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(sbyte value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(float value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(string value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(string value, int fromBase)
        {
            return NullableConversionBase(value, fromBase, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(string value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(ushort value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(uint value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(ulong value)
        {
            return NullableConversionBase(value, Convert.ToUInt64);
        }
    }
}
