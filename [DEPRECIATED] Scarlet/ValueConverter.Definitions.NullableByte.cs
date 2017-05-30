using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static byte? ToNullableByte(bool value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(byte value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(char value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(decimal value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(double value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(short value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(int value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(long value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(object value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToByte);
        }

        public static byte? ToNullableByte(sbyte value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(float value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(string value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(string value, int fromBase)
        {
            return NullableConversionBase(value, fromBase, Convert.ToByte);
        }

        public static byte? ToNullableByte(string value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToByte);
        }

        public static byte? ToNullableByte(ushort value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(uint value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(ulong value)
        {
            return NullableConversionBase(value, Convert.ToByte);
        }
    }
}
