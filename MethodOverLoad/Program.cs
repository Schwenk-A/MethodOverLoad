using System;

namespace MethodOverLoad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Add(0.5, 0.5));
            Console.WriteLine(Add(3,2));
            Console.WriteLine(Add(1, 0, true));
        }


        public static int Add(int intOne, int intTWo)
        {
            return (intOne + intTWo);
        }

        public static double Add(double intOne, double intTwo)
        {

            return (intOne + intTwo);
        }


        public static string Add(int intOne, int intTwo, bool boolOne)
        {
            var sum = intOne + intTwo; 
            if (boolOne && sum>1)
            {
                return $"{sum} dollars";
            }
            else if (boolOne && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}//add variable sum store value of int one and two 
