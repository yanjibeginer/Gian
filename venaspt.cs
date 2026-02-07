using System;

  namespace ComputeAverageApp
 {
    
     class CompleteAverageProgram
     {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter The 5 Grades");

            double grade1 = Convert.ToDouble(Console.ReadLine());
            double grade2 = Convert.ToDouble(Console.ReadLine());
            double grade3 = Convert.ToDouble(Console.ReadLine());
            double grade4 = Convert.ToDouble(Console.ReadLine());
            double grade5 = Convert.ToDouble(Console.ReadLine());

            double average = grade1 + grade2 + grade2 + grade3 + grade3 + grade4 + grade5 / 5;

            Console.WriteLine("The average is " + average + " and round it off " + average);
            Console.ReadKey();

        }
   

    }

}
 








