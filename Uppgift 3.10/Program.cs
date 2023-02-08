using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vilken plats kom du på? : ");
            string val = Console.ReadLine(); 

            switch (val)
            {
                case "1":
                    Console.WriteLine("Du fick guld ");
                    break;
                case "2":
                    Console.WriteLine("Du fick silver ");
                    break;
                case "3":
                    Console.WriteLine("Du fick brons ");
                    break;
                default:
                    Console.WriteLine("Du fick ingen medalj");
                    break;

            }


        }
    }
}
