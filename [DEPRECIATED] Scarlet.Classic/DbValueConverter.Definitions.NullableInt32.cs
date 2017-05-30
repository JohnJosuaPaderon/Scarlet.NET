using System;

namespace Scarlet
{
    partial class DbValueConverter
    {
        public static int? ToNullableInt32(bool value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(byte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(char value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(double value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(short value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(int value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(long value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(float value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(string value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(uint value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }
    }
}
