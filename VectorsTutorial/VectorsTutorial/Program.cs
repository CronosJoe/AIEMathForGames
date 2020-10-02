using System;

namespace VectorsTutorial
{
    class MainClass
    {
       
        public static void Main()
        {
            Vector3 exerciseTester = new Vector3(0, 1, 2);
            Vector3 exerciseTester2 = new Vector3(9, -2, 7);
            Console.WriteLine(exerciseTester.Distance(exerciseTester2));
        }
    }
  
}
