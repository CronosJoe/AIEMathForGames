using System;

namespace VectorsTutorial
{
    class MainClass
    {
       
        public static void Main()
        {
            Binary test = new Binary();
            bool tester = test.IsLeftMostBitSet(0b00101);
            Console.WriteLine(tester);
        }
    }
  
}
