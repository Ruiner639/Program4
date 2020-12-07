using System;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 3 sides of the triangle: ");
            string side_a = Console.ReadLine();
            string side_b = Console.ReadLine();
            string side_c = Console.ReadLine();
            Int32.TryParse(side_a, out int A);
            Int32.TryParse(side_b, out int B);
            Int32.TryParse(side_c, out int C);
            if ((A == B) && (B==C) && (C== A))//Are all parties equal?
            {
                Console.WriteLine("All sides are equal");
            } 
            else if ((A == B) || (B == C) || (C == A))//Are 2 equal sides present?
            {
                if (A == B)
                {
                    Console.WriteLine("Side A and Side B are equal");
                }
                else if (B == C)
                {
                    Console.WriteLine("Side B and Side C are equal");
                }
                else//
                {
                    Console.WriteLine("Side C and Side A are equal");
                }
            }
            else
            {
                Console.WriteLine("Triangle have no equal sides");
            }
            
           
        }
    }
}
