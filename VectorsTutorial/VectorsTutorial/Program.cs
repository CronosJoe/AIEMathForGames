using System;

namespace VectorsTutorial
{
    class MainClass
    {
       
        public static void Main()
        {
            Vector2 exerciseTester = new Vector2(1, 1);
            Vector2 exerciseTester2 = new Vector2(-1, -1);
            Console.WriteLine(exerciseTester.Dot(exerciseTester2));
        }
    }
  
}
