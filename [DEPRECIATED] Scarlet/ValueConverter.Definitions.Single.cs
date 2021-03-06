﻿using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static float ToSingle(bool value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        public static float ToSingle(byte value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        public static float ToSingle(decimal value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        public static float ToSingle(double value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        public static float ToSingle(short value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        public static float ToSingle(int value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        public static float ToSingle(long value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        public static float ToSingle(object value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        public static float ToSingle(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToSingle);
        }

        public static float ToSingle(sbyte value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        public static float ToSingle(float value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        public static float ToSingle(string value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        public static float ToSingle(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToSingle);
        }

        public static float ToSingle(ushort value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        public static float ToSingle(uint value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        public static float ToSingle(ulong value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }
    }
}
