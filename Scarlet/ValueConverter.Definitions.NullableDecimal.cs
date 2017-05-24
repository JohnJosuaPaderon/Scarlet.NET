using System;
using System.Collections.Generic;
using System.Text;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static decimal? ToNullableDecimal(bool value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(byte value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(decimal value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(double value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(short value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(int value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(long value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(object value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(sbyte value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(float value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(string value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(string value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(ushort value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(uint value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(ulong value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }
    }
}
