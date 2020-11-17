using System;

namespace lacos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quer ver a tabuada?");
            string answer = Console.ReadLine();
            if (answer == "sim") {
                for (var j = 0; j <= 10; j++) {
                    Console.WriteLine("tabuada do " + j);
                    for (var i = 0; i <= 10; i++) {
                        Console.WriteLine(j + " x " + i + " = " + (j * i));
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
        }
    }
}
