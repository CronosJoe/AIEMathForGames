using System;
using System.Collections.Generic;

namespace VectorsTutorial
{
    public class Binary
    {
        public bool IsLeftMostBitSet(uint value)
        {

            /* Returns true if the left most (the most significant) bit of value is set and
            false otherwise*/
            Console.WriteLine(value);
            return false;
        }
        public bool IsRightMostBitSet(uint value)
        {
            /*  Returns true if the right most (the least significant) bit of value is set and
 false otherwise */
            return false;
           
        }
        public bool IsBitSet(uint value, char bit_to_check)
        {
            /*• Returns true if the asked for bit is set, and false otherwise. bit_to_check is
zero indexed from the right most bit. i.e 0 is the right most bit and 31 is the
left most. */
            return false; 
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
            return -1;
        }
        public void PrintBinary(byte value)
        {
            Console.WriteLine("print value as a binary");
        }

    }
}
