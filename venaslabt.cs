using System;

  namespace MathApp
 {
    
     class MathProgram
     {

        static void Main(string[] args)
        {
            double num1= -20;
            double num2=15.75;
            double num3=10;
            double num4=2;
            double num5=144;

            Console.WriteLine("Absoulute Value of -20 is:" + Math.Abs(num1));
            Console.WriteLine("Higher Value between 15.75 and 10 is: " + Math.Max(num2, num3));
            Console.WriteLine("2 to the power of 3 is:" + Math.Pow(num4, 3));
            Console.WriteLine("Square root of 144 is: " + Math.Sqrt(num5));
            Console.WriteLine("Ceiling value of 5.75 is " + Math.Ceiling(num2));
            Console.ReadKey();

        }
   

    }

}
 








