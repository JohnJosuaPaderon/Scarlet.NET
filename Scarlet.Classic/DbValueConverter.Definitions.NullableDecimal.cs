using System;

namespace Scarlet
{
    partial class DbValueConverter
    {
        public static decimal? ToNullableDecimal(bool value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(byte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(double value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(short value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(int value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(long value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(float value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(string value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(uint value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }
    }
}
