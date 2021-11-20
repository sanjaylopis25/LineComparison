using System;

namespace LineComprison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Line");
            Console.Write("Enter the Co-rdinate X1: ");
            int X1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate Y1: ");
            int Y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate X2: ");
            int X2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate Y2: ");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second Line");
            Console.Write("Enter the Co-rdinate A1: ");
            int A1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate B1: ");
            int B1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate A2: ");
            int A2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate B2: ");
            int B2 = Convert.ToInt32(Console.ReadLine());

            double PowofpointsX = Math.Pow(2, (X2 - X1));
            double PowofpointsY = Math.Pow(2, (Y2 - Y1));
            double LengthofLine1 = Math.Sqrt((PowofpointsX + PowofpointsY));
            Console.WriteLine("Length of the First Line is: " + LengthofLine1);

            double PowofpointsA = Math.Pow(2, (A2 - A1));
            double PowofpointsB = Math.Pow(2, (B2 - B1));
            double LengthofLine2 = Math.Sqrt((PowofpointsA + PowofpointsB));
            Console.WriteLine("Length of the Second Line is: " + LengthofLine2);

            Console.WriteLine(LengthofLine1.CompareTo(LengthofLine2));
            //Above syntax compares the length of line 1 with length of line 2. Here if length of line 1 is bigger it 
            //gives the ouput as 1, if equals then 0 and if smaller gives the ouput as -1.
            Console.ReadLine();
        }
    }
}
