using System;

namespace Scarlet
{
    partial class DbValueConverter
    {
        public static float? ToNullableSingle(bool value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(byte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(double value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(short value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(int value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(long value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(float value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(string value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(uint value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }
    }
}
