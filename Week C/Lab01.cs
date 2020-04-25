using System;
namespace Lab1
{
    public class Lab01
    {
        public Lab01()
        {
            Console.WriteLine("CS 201 Restaurant Guide\n");
            String response;
            char f;
            char s;
            bool fancy;
            bool spicy;

            Console.WriteLine("Do you like spicy food? (y / n) : ");

            response = Console.ReadLine();
            s = response[0];
            if (((s == 'y') || (s == 'Y')))
            {
                spicy = true;
            }
            else
            {
                spicy = false;
            }
            Console.WriteLine("Do you want to go to a fancy restaurant? (y / n) : ");
            response = Console.ReadLine();
            f = response[0];
            fancy = ((f == 'y') || (f == 'Y'));
            if (spicy)
            {
                if (fancy)
                    Console.WriteLine("I suggest you go to Thai Garden Palace.");
                else
                    Console.WriteLine("I suggest you to go to Alberto's Tacqueria.");
            }
            else
            {
                if (fancy)
                    Console.WriteLine("I suggest you to go to Chez Paris.");
                else
                    Console.WriteLine("I suggest you go to Joe's Diner.");
            }
        }
    }
}
