﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
        public UInt32 colour;
        public Colour()
        {
        }
        public Colour(byte red, byte green, byte blue, byte alpha)
        {
            colour += (uint)red << 24;
            colour += (uint)green << 16;
            colour += (uint)blue << 8;
            colour += (uint)alpha;
        }
        //getting and setting rgb and alpha.
        public byte GetRed()
        {
            UInt32 value = colour & 0xff000000;
            return (byte)((value) >> 24);
        }
        public void SetRed(byte red)
        {
            colour = colour & 0x00ffffff;
            colour |= (UInt32)red << 24;
        }
        public byte GetGreen()
        {
            UInt32 value = colour & 0x00ff0000;
            return (byte)((value) >> 16);
        }
        public void SetGreen(byte green)
        {
            colour = colour & 0x00ffffff;
            colour |= (UInt32)green << 16;
        }
        public byte GetBlue()
        {
            UInt32 value = colour & 0x0000ff00;
            return (byte)((value) >> 8);
        }
        public void SetBlue(byte blue)
        {
            colour = colour & 0x00ffffff;
            colour |= (UInt32)blue << 8;
        }
        public byte GetAlpha()
        {
            UInt32 value = colour & 0x000000ff;
            return (byte)((value));
        }
        public void SetAlpha(byte alpha)
        {
            colour = colour & 0x00ffffff;
            colour |= (UInt32)alpha;
        }
    }
}
