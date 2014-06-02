using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = n;
        int ctr = 0;
        for (int i = 0; i < n/2 + 1; i++)
        {
            string filler = new string('.', ctr);
            Console.Write(filler);
            for (int j = 0; j < counter; j++)
            {
                Console.Write("*");
            }
            Console.Write(filler);
            ctr++;
            counter -= 2;
            Console.WriteLine();
        }
        //----------------
        if (n % 2 == 0)
        {
            counter = 2;
        }
        else
        {
            counter = 3;
        }
        ctr -= 2;
        //----------------
        for (int i = 0; i < n/2; i++)
        {
            string filler = new string('.', ctr);
            Console.Write(filler);
            for (int j = 0; j < counter; j++)
            {
                Console.Write("*");
            }
            Console.Write(filler);
            ctr--;
            counter += 2;
            Console.WriteLine();
        }
    }
}

