using System;

class Program
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal result = 0;
        switch (b)
        {
            case 3:
                result = a + c;
                break;
            case 6:
                result = a * c;
                break;
            case 9:
                result = a % c;
                break;
        }
        decimal r = result;
        if (r % 3 == 0)
        {
            Console.WriteLine(r / 3);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(r % 3);
            Console.WriteLine(result);
        }
    }
}

