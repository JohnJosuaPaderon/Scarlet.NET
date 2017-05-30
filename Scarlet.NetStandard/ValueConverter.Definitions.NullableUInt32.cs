using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static uint? ToNullableUInt32(bool value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(byte value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(char value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(decimal value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(double value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(short value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(int value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(long value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(object value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(sbyte value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(float value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(string value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(string value, int fromBase)
        {
            return NullableConversionBase(value, fromBase, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(string value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(ushort value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(uint value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(ulong value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }
    }
}
