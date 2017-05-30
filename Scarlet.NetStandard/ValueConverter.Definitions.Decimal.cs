using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static decimal ToDecimal(bool value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(byte value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(decimal value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(double value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(short value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(int value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(long value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(object value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToDecimal);
        }

        public static decimal ToDecimal(sbyte value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(float value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(string value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToDecimal);
        }

        public static decimal ToDecimal(ushort value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(uint value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(ulong value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }
    }
}
