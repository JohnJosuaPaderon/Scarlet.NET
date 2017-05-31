using System;

namespace Scarlet
{
    partial class DbValueConverter
    {
        public static double? ToNullableDouble(bool value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(byte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(double value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(short value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(int value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(long value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(float value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(string value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(uint value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }
    }
}
