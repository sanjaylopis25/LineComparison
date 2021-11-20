using System;

namespace LineComprison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Co-rdinate X1: ");
            int X1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate Y1: ");
            int Y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate X2: ");
            int X2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate Y2: ");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            double Powofpoints1 = Math.Pow(2, (X2 - X1));
            double Powofpoints2 = Math.Pow(2, (Y2 - Y1));
            double LengthofLine = Math.Sqrt((Powofpoints1 + Powofpoints2));
            Console.WriteLine("Length of the Line is: " + LengthofLine);
            Console.ReadLine();
        }
    }
}
