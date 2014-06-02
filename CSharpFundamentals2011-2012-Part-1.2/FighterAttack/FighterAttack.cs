using System;

class FighterAttack
{
    public static bool isInRange(int num1, int num2, int number)
    {
        int start = Math.Min(num1, num2);
        int end = Math.Max(num1, num2);
        if (start <= number && number <= end)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        //variables
        int plantX1 = int.Parse(Console.ReadLine());
        int plantY1 = int.Parse(Console.ReadLine());
        int plantX2 = int.Parse(Console.ReadLine());
        int plantY2 = int.Parse(Console.ReadLine());
        int fighterX = int.Parse(Console.ReadLine());
        int fighterY = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());

        int dmgPointMainX = fighterX + distance;
        int dmgPointMainY = fighterY;
        int dmgPointUpX = dmgPointMainX;
        int dmgPointUpY = dmgPointMainY + 1;
        int dmgPointDownX = dmgPointMainX;
        int dmgPointDownY = dmgPointMainY - 1;
        int dmgPointFrontX = dmgPointMainX + 1;
        int dmgPointFrontY = dmgPointMainY;

        int totalDmg = 0;
        //check cases
        if ((isInRange(plantX1, plantX2, dmgPointMainX) == true) && (isInRange(plantY1, plantY2, dmgPointMainY) == true)) totalDmg += 100;
        if ((isInRange(plantX1, plantX2, dmgPointUpX) == true) && (isInRange(plantY1, plantY2, dmgPointUpY) == true)) totalDmg += 50;
        if ((isInRange(plantX1, plantX2, dmgPointDownX) == true) && (isInRange(plantY1, plantY2, dmgPointDownY) == true)) totalDmg += 50;
        if ((isInRange(plantX1, plantX2, dmgPointFrontX) == true) && (isInRange(plantY1, plantY2, dmgPointFrontY) == true)) totalDmg += 75;

        string totalDmgPercent = totalDmg.ToString() + "%";
        Console.WriteLine(totalDmgPercent);
    }
}

