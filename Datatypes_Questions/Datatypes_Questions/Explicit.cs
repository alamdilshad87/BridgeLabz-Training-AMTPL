using System;
namespace Datatypes_Questions
{
    class Explicit
    {
        static void Main(string[] args)
        {
            int num = 65;
            char alpha;
            alpha = (char)num;
            Console.WriteLine($"alphabet is: {alpha}");
            Console.ReadLine();
        }
    }
}