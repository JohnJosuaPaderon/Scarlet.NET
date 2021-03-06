﻿using System;

namespace Scarlet
{
    partial class ValueConverter
    {
        public static sbyte ToSByte(bool value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(byte value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(char value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }
        
        public static sbyte ToSByte(decimal value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(double value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(short value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(int value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(long value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(object value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToSByte);
        }

        public static sbyte ToSByte(sbyte value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(float value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(string value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, Convert.ToSByte);
        }

        public static sbyte ToSByte(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToSByte);
        }

        public static sbyte ToSByte(ushort value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(uint value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(ulong value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }
    }
}
