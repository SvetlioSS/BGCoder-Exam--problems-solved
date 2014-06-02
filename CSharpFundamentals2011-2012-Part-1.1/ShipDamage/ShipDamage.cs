using System;

class ShipDamage
{
    public static bool isInRange(int num1, int num2, int number)
    {
        int start = Math.Min(num1, num2);
        int end = Math.Max(num1, num2);
        if (start < number && number < end)
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

        int sX1 = int.Parse(Console.ReadLine());
        int sY1 = int.Parse(Console.ReadLine());
        int sX2 = int.Parse(Console.ReadLine());
        int sY2 = int.Parse(Console.ReadLine());
        int sX3 = sX1;
        int sY3 = sY2;
        int sX4 = sX2;
        int sY4 = sY1;

        int h = int.Parse(Console.ReadLine());

        int cX1 = int.Parse(Console.ReadLine());
        int cY1 = int.Parse(Console.ReadLine());
        int cX2 = int.Parse(Console.ReadLine());
        int cY2 = int.Parse(Console.ReadLine());
        int cX3 = int.Parse(Console.ReadLine());
        int cY3 = int.Parse(Console.ReadLine());

        int dmgPoint1_x = cX1;
        int dmgPoint2_x = cX2;
        int dmgPoint3_x = cX3;
        int dmgPoint1_y = 2 * h - cY1;
        int dmgPoint2_y = 2 * h - cY2;
        int dmgPoint3_y = 2 * h - cY3;

        int totalDmg = 0;
        //---------------------------------
        //check for dmg on the corners
        bool dmgOnCorner1 = (dmgPoint1_x == sX1) && (dmgPoint1_y == sY1);
        bool dmgOnCorner2 = (dmgPoint1_x == sX2) && (dmgPoint1_y == sY2);
        bool dmgOnCorner3 = (dmgPoint1_x == sX3) && (dmgPoint1_y == sY3);
        bool dmgOnCorner4 = (dmgPoint1_x == sX4) && (dmgPoint1_y == sY4);
        //dmg pt2
        bool dmgOnCorner5 = (dmgPoint2_x == sX1) && (dmgPoint2_y == sY1);
        bool dmgOnCorner6 = (dmgPoint2_x == sX2) && (dmgPoint2_y == sY2);
        bool dmgOnCorner7 = (dmgPoint2_x == sX3) && (dmgPoint2_y == sY3);
        bool dmgOnCorner8 = (dmgPoint2_x == sX4) && (dmgPoint2_y == sY4);
        //dmg pt3
        bool dmgOnCorner9 = (dmgPoint3_x == sX1) && (dmgPoint3_y == sY1);
        bool dmgOnCorner10 = (dmgPoint3_x == sX2) && (dmgPoint3_y == sY2);
        bool dmgOnCorner11 = (dmgPoint3_x == sX3) && (dmgPoint3_y == sY3);
        bool dmgOnCorner12 = (dmgPoint3_x == sX4) && (dmgPoint3_y == sY4);

        if (dmgOnCorner1) totalDmg += 25;
        if (dmgOnCorner2) totalDmg += 25;
        if (dmgOnCorner3) totalDmg += 25;
        if (dmgOnCorner4) totalDmg += 25;
        if (dmgOnCorner5) totalDmg += 25;
        if (dmgOnCorner6) totalDmg += 25;
        if (dmgOnCorner7) totalDmg += 25;
        if (dmgOnCorner8) totalDmg += 25;
        if (dmgOnCorner9) totalDmg += 25;
        if (dmgOnCorner10) totalDmg += 25;
        if (dmgOnCorner11) totalDmg += 25;
        if (dmgOnCorner12) totalDmg += 25;
        //-------------------------------
        //check for dmg on the sides
        if (((dmgPoint1_y == sY1) || (dmgPoint1_y == sY2)) && (isInRange(sX1, sX2, dmgPoint1_x))) totalDmg += 50;
        if (((dmgPoint1_x == sX1) || (dmgPoint1_x == sX2)) && (isInRange(sY1, sY2, dmgPoint1_y))) totalDmg += 50;

        if (((dmgPoint2_y == sY1) || (dmgPoint2_y == sY2)) && (isInRange(sX1, sX2, dmgPoint2_x))) totalDmg += 50;
        if (((dmgPoint2_x == sX1) || (dmgPoint2_x == sX2)) && (isInRange(sY1, sY2, dmgPoint2_y))) totalDmg += 50;

        if (((dmgPoint3_y == sY1) || (dmgPoint3_y == sY2)) && (isInRange(sX1, sX2, dmgPoint3_x))) totalDmg += 50;
        if (((dmgPoint3_x == sX1) || (dmgPoint3_x == sX2)) && (isInRange(sY1, sY2, dmgPoint3_y))) totalDmg += 50;
        //---------------------------------
        //check for dmg inside the ship
        if (isInRange(sX1, sX2, dmgPoint1_x) && isInRange(sY1, sY2, dmgPoint1_y)) totalDmg += 100;
        if (isInRange(sX1, sX2, dmgPoint2_x) && isInRange(sY1, sY2, dmgPoint2_y)) totalDmg += 100;
        if (isInRange(sX1, sX2, dmgPoint3_x) && isInRange(sY1, sY2, dmgPoint3_y)) totalDmg += 100;
        //Print total damage
        string totalDmgInPercent = totalDmg.ToString() + "%";
        Console.WriteLine(totalDmgInPercent);
    }
}

