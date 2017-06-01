using System;

namespace Scarlet
{
    partial class DbValueConverter
    {
        public static byte? ToNullableByte(bool value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(byte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(char value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(double value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(short value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(int value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(long value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(float value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(string value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(uint value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }
    }
}
