using System;

namespace VectorsTutorial
{
    class MainClass
    {
       
        public static void Main()
        {
            Vector3 exerciseTester = new Vector3(10, 0, 18);
            Vector3 exerciseTester2 = new Vector3(-7.5f, 0, 9);
            Console.WriteLine(exerciseTester.AngleBetween(exerciseTester2));
        }
    }
  
}
