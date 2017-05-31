using System;

namespace Scarlet
{
    partial class DbValueConverter
    {
        public static uint? ToNullableUInt32(bool value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(byte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(char value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(double value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(short value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(int value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(long value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(float value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(string value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(uint value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }
    }
}
