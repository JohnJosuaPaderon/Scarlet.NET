using System;

namespace Scarlet
{
    partial class DbValueConverter
    {
        public static bool ToBoolean(bool value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(byte value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(double value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(short value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(int value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(long value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(object value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(float value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(string value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(uint value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }
    }
}
