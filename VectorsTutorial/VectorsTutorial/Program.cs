using System;

namespace VectorsTutorial
{
    class MainClass
    {
       
        public static void Main()
        {
            Binary test = new Binary();
            bool tester = test.IsRightMostBitSet(0b10000000000000000000000000000000);
            test.PrintBinary(0b11111111);
        }
    }
  
}
