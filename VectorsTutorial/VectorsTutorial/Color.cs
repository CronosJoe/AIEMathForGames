using System;
namespace VectorsTutorial
{
    public class Color
    {
        public UInt32 color;
        public Color()
        {
        }
        public Color(byte red, byte green, byte blue, byte alpha)
        { }
        //getting and setting rgb and alpha.
        public byte GetRed()
        {
            UInt32 value = color & 0xff000000;
            return (byte)((value) >> 24);
        }
        public void SetRed(byte red)
        {
            color = color & 0x00ffffff;
            color |= (UInt32)red << 24;
        }
        public byte GetGreen()
        {
            UInt32 value = color & 0xff000000;
            return (byte)((value) >> 24);
        }
        public void SetGreen(byte green)
        {
            color = color & 0x00ffffff;
            color |= (UInt32)green << 24;
        }
        public byte GetBlue()
        {
            UInt32 value = color & 0xff000000;
            return (byte)((value) >> 24);
        }
        public void SetBlue(byte blue)
        {
            color = color & 0x00ffffff;
            color |= (UInt32)blue << 24;
        }
        public byte GetAlpha()
        {
            UInt32 value = color & 0xff000000;
            return (byte)((value) >> 24);
        }
        public void SetAlpha(byte alpha)
        {
            color = color & 0x00ffffff;
            color |= (UInt32)alpha << 24;
        }
    }
}
