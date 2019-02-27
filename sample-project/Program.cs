using System;

namespace sample_project
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloAttribute test = new HelloAttribute();
            Console.WriteLine($"result: {test.IsValid(1)}");
        }
    }
}
