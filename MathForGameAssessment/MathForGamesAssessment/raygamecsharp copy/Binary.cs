using System;
using System.Collections.Generic;

namespace VectorsTutorial
{
    public class Binary
    {
        //checks the left most bit
        public bool IsLeftMostBitSet(uint value)
        {
            return (((value >> 31) & 1) > 0);
        }
        //checks least significant bit
        public bool IsRightMostBitSet(uint value)
        {
            return (((value >> 0) & 1) > 0);
        }
        //checks if a bit at index bit_to_check is set or not.
        public bool IsBitSet(uint value, char bit_to_check)
        {
            return (((value >> (bit_to_check - 1)) & 1) > 0);
        }
        //gets the bit on the rightmost side.
        public int GetRightMostSetBit(uint value)
        {
            int pos = 0;
            for (int i = 1; i <= 32; i++) //since it is a 32 bit integar going through all 32 should eventually find a number and return the position, if no number is found loop ends and -1 is returned.
            {
                if ((((value >> (i - 1)) & 1) > 0))
                {
                    return pos;
                }
                pos++;
            }
            return -1;
        }
        //prints it as a binary number.
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

