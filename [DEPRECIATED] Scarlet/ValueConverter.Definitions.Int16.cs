using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static short ToInt16(bool value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(byte value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(char value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(decimal value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(double value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(short value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(int value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(long value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(object value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToInt16);
        }

        public static short ToInt16(sbyte value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(float value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(string value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, Convert.ToInt16);
        }

        public static short ToInt16(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToInt16);
        }

        public static short ToInt16(ushort value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(uint value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }

        public static short ToInt16(ulong value)
        {
            return ConversionBase(value, Convert.ToInt16);
        }
    }
}
