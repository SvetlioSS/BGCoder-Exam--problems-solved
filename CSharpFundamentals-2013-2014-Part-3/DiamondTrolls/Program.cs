using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int width = n * 2 + 1;
        int height = 6 + ((n - 3) / 2 * 3);
        int counter = (width - n) / 2 - 1;
        int counterRight = n + (width - n) / 2 - 1;
        int counterBottom = 1;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == 0)
                {
                    string filler = new string('*', n);
                    int dots = (width - n) / 2;
                    Console.Write(new string('.', dots) + filler + new string('.', dots));
                    break;
                }
                if (j == width - n - 1)
                {
                    Console.Write('*');
                }
                else if (j == counter)
                {
                    Console.Write('*');
                    counter--;
                }
                else if (j == counterRight)
                {
                    Console.Write('*');
                }
                else if (counter == -1 && i == height - n - 1)
                {
                    Console.Write('*');
                }
                else if ((i > height - n - 1) && ((j == counterBottom) || (j == width - counterBottom - 1)))
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            if (i > height - n - 1) counterBottom++;
            counterRight++;
            Console.WriteLine();
        }
    }
}

