using System;

namespace linecompproblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison problem");

            Console.WriteLine("Enter the choice");
            Console.WriteLine(" 1.calculatinglinelength");
            Console.WriteLine(" 2.LinesisEqualorNot");
            Console.WriteLine(" 3.TwoLinesComparison");
            Console.WriteLine(" 4.ComparisonUsingAllMethods");
            

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    calculatinglinelength a = new calculatinglinelength();
                    a.Calculatinglinelength();

                    break;
                case 2:
                    LinesisEqualorNot b = new LinesisEqualorNot();
                    b.linesequalornot();
                    break;
                case 3:
                    TwoLinesComparison c = new TwoLinesComparison();
                    c.Comparison();
                    break;

                case 4:
                    ComparisonUsingAllMethods d = new ComparisonUsingAllMethods();
                    d.AllComparison();
                    break;

                default:
                    Console.WriteLine("Please enter the correct choice");
                    break;
            }






          
           

            
            

        }
    }
}
