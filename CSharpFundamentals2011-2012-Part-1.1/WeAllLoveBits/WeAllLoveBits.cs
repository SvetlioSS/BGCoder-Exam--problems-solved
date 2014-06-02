using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            string binaryNum = Convert.ToString(num, 2);
            string reversedNum = "";
            for (int j = binaryNum.Length - 1; 0 <= j; j--)
			{
			    reversedNum += binaryNum[j];
			}
            int reversedNumToInt = Convert.ToInt32(reversedNum, 2);
            int numNew = (num ^ ~num) & reversedNumToInt;
            numbers[i] = numNew;
        }
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}

