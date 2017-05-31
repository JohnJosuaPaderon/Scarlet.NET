using System;

namespace Scarlet
{
    partial class DbValueConverter
    {
        public static sbyte? ToNullableSByte(bool value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(byte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(char value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(double value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(short value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(int value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(long value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(float value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(string value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(uint value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }
    }
}
