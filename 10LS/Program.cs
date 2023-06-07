using System;

namespace _10LS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point nk1 = new Point();
            Point nk2 = new Point();
            nk1.setX(7);
            nk1.setY(0);
            nk2.setX(5);
            nk2.setY(2); 
            Console.WriteLine(nk1.StringMe());
            Console.WriteLine(nk2.StringMe());
            Console.WriteLine(nk2.GetLine(nk1));
            Console.WriteLine(nk1.GetLine(nk2));
        }
    }
}