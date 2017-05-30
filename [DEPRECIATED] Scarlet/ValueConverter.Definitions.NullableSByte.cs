using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static sbyte? ToNullableSByte(bool value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(byte value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(char value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(decimal value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(double value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(short value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(int value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(long value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(object value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(sbyte value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(float value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(string value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(string value, int fromBase)
        {
            return NullableConversionBase(value, fromBase, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(string value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(ushort value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(uint value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(ulong value)
        {
            return NullableConversionBase(value, Convert.ToSByte);
        }
    }
}
