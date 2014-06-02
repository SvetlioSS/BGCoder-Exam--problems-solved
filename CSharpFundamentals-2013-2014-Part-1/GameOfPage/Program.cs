using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    private static string CheckForCookie(int[,] matrix, int row, int col)
    {
        int counter = 0;
        int cellRow = row;
        int cellCol = col;
        int startRow = 0;
        int startCol = 0;
        int endRow = 0;
        int endCol = 0;
        if (row == 0) startRow = 0; endRow = 1;
        if (row == 15) startRow = 14; endRow = 15;
        if (row != 0 && row != 15) startRow = row - 1; endRow = row + 1;
        if (col == 15) startCol = 14; endCol = 15;
        if (col == 0) startCol = 0; endCol = 1;
        if (col != 15 && col != 0) startCol = col - 1; endCol = col + 1;
        if (matrix[row, col] == 1)
        {
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        counter++;
                    }
                }
            }
            if (counter == 9)
            {
                return "cookie";
            }
            else if (counter == 1)
            {
                return "cookie crumb";
            }
            else if (counter > 1 && counter < 9)
            {
                return "broken cookie";
            }
            else
	        {
                return "bug";                    
	        }
        }
        else
        {
            return "smile";
        }
    }

    private static int[,] RemoveCookie(int[,] matrix, int row, int col)
    {
        if ((row != 0 && row != 15) && (col != 0 && col != 15))
        {
            for (int i = row - 1; i < row + 1; i++)
            {
                for (int j = col - 1; j < col + 1; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        return matrix;
    }

    static void Main(string[] args)
    {
        int[,] matrix = new int[16, 16];
        for (int i = 0; i < 16; i++)
        {
            string row = Console.ReadLine();
            int number = Convert.ToInt32(row, 2);
            int counter = 15;
            for (int j = 0; j < 16; j++)
            {
                matrix[i, j] = (number >> counter) & 1;
                counter--;
            }
        }
        double totalSumToPay = 0;
        List<string> list = new List<string>();
        while (true)
        {
            string word = Console.ReadLine();
            if (word == "what is")
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                string wordToSay = CheckForCookie(matrix, number1, number2);
                list.Add(wordToSay);
            }
            else if (word == "buy")
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                string wordToSay = CheckForCookie(matrix, number1, number2);
                if (wordToSay == "smile")
                {
                    list.Add(wordToSay);
                }
                else if (wordToSay == "cookie crumb" || wordToSay == "broken cookie")
                {
                    list.Add("page");
                }
                else if (wordToSay == "cookie")
                {
                    totalSumToPay += 1.79;
                    matrix = RemoveCookie(matrix, number1, number2);
                }
            }
            else if (word == "paypal")
            {
                list.Add(totalSumToPay.ToString());
                break;
            }
        }
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

