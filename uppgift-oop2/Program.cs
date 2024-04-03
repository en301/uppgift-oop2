using System;

namespace uppgift_oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            namn p = new namn();
            Console.WriteLine("Förnamn?");
            p.Förnamm = Console.ReadLine();
            Console.WriteLine("Efternamn?");
            p.Efternamn = Console.ReadLine();
            Console.WriteLine("");
            p.Namn();
        }
    }
}

