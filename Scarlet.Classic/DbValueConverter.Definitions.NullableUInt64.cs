using System;

namespace Scarlet
{
    partial class DbValueConverter
    {
        public static ulong? ToNullableUInt64(bool value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(byte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(char value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(double value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(short value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(int value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(long value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(float value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(string value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(uint value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }
    }
}
