using System;

namespace proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldiers.SamuraiSoldier samurai = new Soldiers.SamuraiSoldier("Goto Södziro");
            Soldiers.RomanSoldier roman = new Soldiers.RomanSoldier("Roma");

            System.Console.WriteLine(roman);
            System.Console.WriteLine(samurai);
            Console.WriteLine($"figth");
            Console.WriteLine($"figth");
            Console.WriteLine($"figth");

            roman.Atack(samurai);
            System.Console.WriteLine(roman);
            System.Console.WriteLine(samurai);

            Console.WriteLine($"figth");
            Console.WriteLine($"figth");
            Console.WriteLine($"figth");

            samurai.Atack(roman);
            System.Console.WriteLine(roman);
            System.Console.WriteLine(samurai);

        }
    }
}
