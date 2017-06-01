using System;

namespace Scarlet
{
    partial class DbValueConverter
    {
        public static short? ToNullableInt16(bool value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(byte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(char value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(double value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(short value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(int value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(long value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(float value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(string value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(uint value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }
    }
}
