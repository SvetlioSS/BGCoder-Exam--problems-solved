using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] cards = new int[5];
        string card1 = Console.ReadLine();
        string card2 = Console.ReadLine();
        string card3 = Console.ReadLine();
        string card4 = Console.ReadLine();
        string card5 = Console.ReadLine();
        string[] tmpArray = new string[5];
        tmpArray[0] = card1;
        tmpArray[1] = card2;
        tmpArray[2] = card3;
        tmpArray[3] = card4;
        tmpArray[4] = card5;
        for (int i = 0; i < 5; i++)
        {
            if (tmpArray[i] == "J")
            {
                tmpArray[i] = Convert.ToString(11);
            }
            if (tmpArray[i] == "Q")
            {
                tmpArray[i] = Convert.ToString(12);
            }
            if (tmpArray[i] == "K")
            {
                tmpArray[i] = Convert.ToString(13);
            }
            if (tmpArray[i] == "A")
            {
                tmpArray[i] = Convert.ToString(1);
            }
        }
        cards[0] = Convert.ToInt32(tmpArray[0]);
        cards[1] = Convert.ToInt32(tmpArray[1]);
        cards[2] = Convert.ToInt32(tmpArray[2]);
        cards[3] = Convert.ToInt32(tmpArray[3]);
        cards[4] = Convert.ToInt32(tmpArray[4]);
        int countCardOne = 0;
        int countCardTwo = 0;
        int countCardThree = 0;
        int countCardFour = 0;
        int countCardFive = 0;
        for (int i = 0; i < 5; i++)
        {
            if (cards[0] == cards[i])
            {
                countCardOne++;
            }
            if (cards[1] == cards[i])
            {
                countCardTwo++;
            }
            if (cards[2] == cards[i])
            {
                countCardThree++;
            }
            if (cards[3] == cards[i])
            {
                countCardFour++;
            }
            if (cards[4] == cards[i])
            {
                countCardFive++;
            }
        }
        //check if 4 cards
        if (cards[0] == cards[1] && cards[1] == cards[2] &&
            cards[2] == cards[3] && cards[3] == cards[4])
        {
            Console.WriteLine("Impossible");
        }
        else if (countCardOne == 4 || countCardTwo == 4)
        {
            Console.WriteLine("Four of a Kind");
        }
        //check if 3 equal cards
        else if (countCardOne == 3 || countCardTwo == 3 || countCardThree == 3)
        {
            if (countCardOne == 2 || countCardTwo == 2 || countCardThree == 2 ||
                countCardFour == 2 || countCardFive == 2)
            {
                Console.WriteLine("Full House");
            }
            else
            {
                Console.WriteLine("Three of a Kind");
            }
        }
        //check if 2 equal cards
        else if (countCardOne == 2 || countCardTwo == 2 || countCardThree == 2 ||
                countCardFour == 2 || countCardFive == 2)
        {
            int ctr = 0;
            if (countCardOne == 2) ctr++;
            if (countCardTwo == 2) ctr++;
            if (countCardThree == 2) ctr++;
            if (countCardFour == 2) ctr++;
            if (countCardFive == 2) ctr++;
            if (ctr == 4) Console.WriteLine("Two Pairs");
            if (ctr == 2) Console.WriteLine("One Pair");
        }
        else if (countCardOne == 1 && countCardTwo == 1 && countCardThree == 1 &&
                 countCardFour == 1 && countCardFive == 1)
        {
            //sort the array
            Array.Sort(cards);
            //check if Straight when a = 1
            int ctr2 = 0;
            for (int i = 1; i <= 4; i++)
            {
                if (cards[i] == cards[i - 1] + 1)
                {
                    ctr2++;
                }
            }
            if (ctr2 == 4)
            {
                Console.WriteLine("Straight");
            }
            //check if Straight when a = 14
            int ctr3 = 0;
            if (cards[0] == 1 || cards[1] == 1 || cards[2] == 1 ||
                cards[3] == 1 || cards[4] == 1)
            {
                int tmpCard = cards[4];
                cards[4] = 14;
                cards[0] = tmpCard;
                Array.Sort(cards);
                for (int i = 1; i <= 4; i++)
                {
                    if (cards[i] == cards[i - 1] + 1)
                    {
                        ctr3++;
                    }
                }
                if (ctr3 == 4)
                {
                    Console.WriteLine("Straight");
                }
            }
            if (ctr2 != 4 && ctr3 != 4)
            {
                Console.WriteLine("Nothing");
            }
        }
    }
}

