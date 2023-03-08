using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collect input from the user
            Console.WriteLine("Enter coodinate x of dot A: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coodinate y of dot A: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coodinate x of dot B: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coodinate y of dot B: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coodinate x of dot C: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coodinate x of dot C: ");
            double y3 = double.Parse(Console.ReadLine());

            //Print out the length
            double lengthOfAB = Math.Sqrt(Math.Pow((y2 - y1), 2) + Math.Pow((x2 - x1), 2));
            double lengthOfBC = Math.Sqrt(Math.Pow((y3 - y2), 2) + Math.Pow((x3 - x2), 2));
            double lengthOfAC = Math.Sqrt(Math.Pow((y3 - y1), 2) + Math.Pow((x3 - x1), 2));
            Console.WriteLine("Length of AB is: '{0}'",lengthOfAB);
            Console.WriteLine("Length of BC is: '{0}'", lengthOfBC);
            Console.WriteLine("Length of AC is: '{0}'\n", lengthOfAC);

            //Calculation to find if it right angle (delta must be close to 0)
            double deltaA = Math.Abs(Math.Pow(lengthOfBC,2)-(Math.Pow(lengthOfAB, 2)+ Math.Pow(lengthOfAC, 2)));
            double deltaB = Math.Abs(Math.Pow(lengthOfAC, 2) - (Math.Pow(lengthOfBC, 2) + Math.Pow(lengthOfAB, 2)));
            double deltaC = Math.Abs(Math.Pow(lengthOfAB, 2) - (Math.Pow(lengthOfAC, 2) + Math.Pow(lengthOfBC, 2)));

            //If triangle is equialaral
            if ((lengthOfAB == lengthOfBC) && (lengthOfAB == lengthOfAC))
            {
                Console.WriteLine("Triangle IS 'Equilateral'");
                Console.WriteLine("Triangle IS NOT 'Isoscelese'");
                Console.WriteLine("Triangle IS NOT 'Right'\n");
            }
            //When triangle is Isoscelese and right
            else if ((deltaA < 0.0001 && lengthOfAB == lengthOfAC) || (deltaB < 0.0001 && lengthOfAB == lengthOfBC) || (deltaC < 0.0001 && lengthOfBC == lengthOfAC))
            {
                Console.WriteLine("Triangle IS NOT 'Equilateral'");
                Console.WriteLine("Triangle IS 'Isoscelese'");
                Console.WriteLine("Triangle IS 'Right'\n");
            }
            //When triangle is right
            else if ((deltaA < 0.0001) || (deltaB < 0.0001) || (deltaC < 0.0001))
            {
                Console.WriteLine("Triangle IS NOT 'Equilateral'");
                Console.WriteLine("Triangle IS NOT 'Isoscelese'");
                Console.WriteLine("Triangle IS 'Right'\n");
            }
            //When triangle is Isoscelese
            else if (lengthOfAB == lengthOfBC || lengthOfAB == lengthOfAC || lengthOfAC == lengthOfBC)
            {
                Console.WriteLine("Triangle IS NOT 'Equilateral'");
                Console.WriteLine("Triangle IS 'Isoscelese'");
                Console.WriteLine("Triangle IS NOT 'Right'\n");
            }
            else //If not any of condition
            {
                Console.WriteLine("Triangle IS NOT 'Equilateral'");
                Console.WriteLine("Triangle IS NOT 'Isoscelese'");
                Console.WriteLine("Triangle IS NOT 'Right'\n");
            }

            //the perimeter of the triangle
            double perimeter = lengthOfAB + lengthOfAC + lengthOfBC;
            Console.WriteLine("Perimeter: '{0}'\n",perimeter);

            //even numbers from 0 to value of triangle perimeter
            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
            for (int i = 0; i <= perimeter; i++) 
            {
                Console.WriteLine(i);
                i++;
            }


            Console.ReadKey();
        }
    }
}
