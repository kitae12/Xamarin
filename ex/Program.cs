using System;
//
namespace Lecture_1
{

   class Program
   {
        static void Main(string[] args)
        {
            First();

            void First()
            {
                Console.WriteLine("hi");
                Console.WriteLine("hihi");
                Console.ReadLine();
            }
        }
   }
}

/*
class ArrayExample
{
    private static Console GetConsole()
    {
        return Console;
    }

    static void Main(Console console)
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h'};
        string name = "";
        int[] a = new int[10];
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }

        console.ReadKey();
    }

    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}
*/
