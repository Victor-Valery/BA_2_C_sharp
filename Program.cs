using System; // system library

namespace BA_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We started C# education");
            Console.WriteLine("We started C# education");
            Console.Write("We started C# education");
            Console.Write("We started C# education");

            /*
            Console.Write("We started C# education");
            Console.Write("We started C# education");
            */

            Console.WriteLine("We started C# education"); // Intellisense
            Console.WriteLine("We started C# education"); // Intellisense
            Console.WriteLine("We started C# education"); // Intellisense
            Console.WriteLine("We started C# education"); // Intellisense

            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();


            Console.BackgroundColor = ConsoleColor.DarkBlue;

            // variable definition

            string name1 = "C# Lesson";

            int myNumber = 15;

            int myNumber1 = 10;

            int toplam = myNumber + myNumber1;

            bool myBoolen = myNumber > myNumber1;

            double myDouble = 25.6;

            float myFloat = 100.99f;

            decimal myDecimal = 5999.99m;

            char myChar = '*';

            string name2 = "Victor";
            string surname2 = "Valery";

            string name3;
            string surname3;

            Console.Write("Enter your name: ");
            name3 = Console.ReadLine();

            Console.Write("Enter your surname: ");
            surname3 = Console.ReadLine();
            

            // string interpolation

            Console.WriteLine($"Name: {name2} \nSurname: {surname2}");
            Console.WriteLine($"Welcome Mr/Mrs {name3} {surname3}");


            Console.WriteLine(name1);
            Console.WriteLine(toplam);
            Console.WriteLine(myBoolen);



        }
    }
}
