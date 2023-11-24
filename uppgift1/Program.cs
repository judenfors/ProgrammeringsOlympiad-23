using System;

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Ordet?");
        string ordet = Console.ReadLine();

        Console.WriteLine("Antal upprepningar?");
        int rep = int.Parse(Console.ReadLine());

        if(ordet.Length < 9 && rep < 9) 
        {
            Console.WriteLine("Svar: " + string.Concat(Enumerable.Repeat(ordet, rep)));
        }

        else
        {
            Console.WriteLine("För långt");
        }
    }
}