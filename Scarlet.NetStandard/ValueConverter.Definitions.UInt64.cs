﻿using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static ulong ToUInt64(bool value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(byte value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(char value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(decimal value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(double value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(short value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(int value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(long value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(object value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToUInt64);
        }

        public static ulong ToUInt64(sbyte value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(float value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(string value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, Convert.ToUInt64);
        }

        public static ulong ToUInt64(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToUInt64);
        }

        public static ulong ToUInt64(ushort value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(uint value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(ulong value)
        {
            return ConversionBase(value, Convert.ToUInt64);
        }
    }
}
