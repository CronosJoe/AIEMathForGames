using System;
namespace VectorsTutorial
{
    public class Colour
    {
        public UInt32 colour;
        public Colour()
        {
        }
        public Colour(byte red, byte green, byte blue, byte alpha)
        { }
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
            UInt32 value = colour & 0xff000000;
            return (byte)((value) >> 24);
        }
        public void SetGreen(byte green)
        {
            colour = colour & 0x00ffffff;
            colour |= (UInt32)green << 24;
        }
        public byte GetBlue()
        {
            UInt32 value = colour & 0xff000000;
            return (byte)((value) >> 24);
        }
        public void SetBlue(byte blue)
        {
            colour = colour & 0x00ffffff;
            colour |= (UInt32)blue << 24;
        }
        public byte GetAlpha()
        {
            UInt32 value = colour & 0xff000000;
            return (byte)((value) >> 24);
        }
        public void SetAlpha(byte alpha)
        {
            colour = colour & 0x00ffffff;
            colour |= (UInt32)alpha << 24;
        }
    }
}

