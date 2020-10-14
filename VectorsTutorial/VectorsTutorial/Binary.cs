using System;
using System.Collections.Generic;

namespace VectorsTutorial
{
    public class Binary
    {
        public bool IsLeftMostBitSet(uint value)
        {
            return (((value >> 31) & 1) > 0);
        }
        public bool IsRightMostBitSet(uint value)
        {
            return (((value >> 0) & 1) > 0);
        }
        public bool IsBitSet(uint value, char bit_to_check)
        {
            return (((value >> (bit_to_check - 1)) & 1) > 0); //doesn't work if bit to check is 0 cause it will shift -1 bits over
        }
        public int GetRightMostSetBit(uint value)
        {
            /* 
• This function returns the index of the right most bit set to 1 in value
• If no bits are set, it returns -1
• For example
o 00000001 would return 0
o 10011100 would return 2
o 01010000 would return 4
o 00000000 would return -1
             */
            int pos = 0;
            for(int i = 1; i <= 32; i++) //since it is a 32 bit integar going through all 32 should eventually find a number and return the position, if no number is found loop ends and -1 is returned.
            {
                if((((value >> (i - 1)) &  1) > 0))
                {
                    return pos;
                }
                pos++;
            }
            return -1;
        }
        public void PrintBinary(byte value)
        {
            for (int i = 8; i >= 1; i--) 
            {
                if ((((value >> (i - 1)) & 1) > 0))
                {
                    Console.Write(1);
                }
                else
                {
                    Console.Write(0);
                }
            }
        }

    }
}
