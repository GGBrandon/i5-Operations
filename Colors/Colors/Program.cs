using System;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primary Colors- Red, Blue, and Yellow");


            Begin:
            Console.WriteLine("Please press 1 for Red, 2 for Blue, and 3 for Yellow");
            Console.WriteLine("Please press again, to see the combination of the colors, you must only input primary colors");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            { Console.WriteLine("You choose Red");
                Console.WriteLine("Please choose another color");
                int Coption = Convert.ToInt32(Console.ReadLine());
                if (Coption == 2)
                    Console.WriteLine("Red + Blue = Purple");
                Console.ReadKey();
                if (Coption == 3)
                    Console.WriteLine("Red + Yellow = Orange");
                Console.ReadKey();
                if (Coption == 1)
                    Console.WriteLine("Error, Red + Red, nothing changes");
                Console.ReadKey();
                { goto Begin; }
            }
            if (option == 2)
            {
                Console.WriteLine("You choose Blue"); 
                    Console.WriteLine("Please choose another color");
                    int Coption = Convert.ToInt32(Console.ReadLine());
                    if (Coption == 1)
                        Console.WriteLine("Blue + Red = Purple");
                    Console.ReadKey();
                    if (Coption == 3)
                        Console.WriteLine("Blue + Yellow = Green");
                    Console.ReadKey();
                    if (Coption == 2)
                        Console.WriteLine("Error, Blue + Blue, nothing changes");
                    Console.ReadKey();
                    { goto Begin; }
            }
            if (option == 3)
            {
                Console.WriteLine("You choose Yellow");
                Console.WriteLine("Please choose another color");
                int Coption = Convert.ToInt32(Console.ReadLine());
                if (Coption == 1)
                    Console.WriteLine("Yellow + Red = Orange");
                Console.ReadKey();
                if (Coption == 2)
                    Console.WriteLine("Yellow + Blue = Green");
                Console.ReadKey();
                if (Coption == 3)
                    Console.WriteLine("Error, Yellow + Yellow, nothing changes");
                Console.ReadKey();
                { goto Begin; }
            }
            else
                Console.WriteLine("Error"); 
                Console.WriteLine("Please press 1 for Red, 2 for Blue, and 3 for Yellow");
            goto Begin; 

            } 
    }
}
