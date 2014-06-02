using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int totalGames = int.Parse(Console.ReadLine());
        int playerOneGamesWon = 0;
        BigInteger playerOneTotalScore = 0;
        int playerTwoGamesWon = 0;
        BigInteger playerTwoTotalScore = 0;
        bool xCardDrawnBySecondPlayer = false;
        bool xCardDrawnByFirstPlayer = false;
        for (int game = 0; game < totalGames; game++)
        {
            int playerOneScore = 0;
            int playerTwoScore = 0;
            for (int i = 0; i < 6; i++)
            {
                string card = Console.ReadLine();
                if (i >= 0 && i <= 2)
                {
                    switch (card)
                    {
                        case "A": playerOneScore += 1; break;
                        case "J": playerOneScore += 11; break;
                        case "Q": playerOneScore += 12; break;
                        case "K": playerOneScore += 13; break;
                        case "2": playerOneScore += 10; break;
                        case "3": playerOneScore += 9; break;
                        case "4": playerOneScore += 8; break;
                        case "5": playerOneScore += 7; break;
                        case "6": playerOneScore += 6; break;
                        case "7": playerOneScore += 5; break;
                        case "8": playerOneScore += 4; break;
                        case "9": playerOneScore += 3; break;
                        case "10": playerOneScore += 2; break;
                        case "Z": playerOneTotalScore *= 2; break;
                        case "Y": playerOneTotalScore -= 200; break;
                        case "X": xCardDrawnByFirstPlayer = true; break;
                    }
                }
                else if (i >= 3 && i <= 5)
                {
                    switch (card)
                    {
                        case "A": playerTwoScore += 1; break;
                        case "J": playerTwoScore += 11; break;
                        case "Q": playerTwoScore += 12; break;
                        case "K": playerTwoScore += 13; break;
                        case "2": playerTwoScore += 10; break;
                        case "3": playerTwoScore += 9; break;
                        case "4": playerTwoScore += 8; break;
                        case "5": playerTwoScore += 7; break;
                        case "6": playerTwoScore += 6; break;
                        case "7": playerTwoScore += 5; break;
                        case "8": playerTwoScore += 4; break;
                        case "9": playerTwoScore += 3; break;
                        case "10": playerTwoScore += 2; break;
                        case "Z": playerTwoTotalScore *= 2; break;
                        case "Y": playerTwoTotalScore -= 200; break;
                        case "X": xCardDrawnBySecondPlayer = true; break;
                    }
                }
            }
            if (xCardDrawnByFirstPlayer == true && xCardDrawnBySecondPlayer == true)
            {
                playerOneTotalScore += 50;
                playerTwoTotalScore += 50;
                xCardDrawnByFirstPlayer = false;
                xCardDrawnBySecondPlayer = false;
            }
            else if (xCardDrawnByFirstPlayer == true && xCardDrawnBySecondPlayer == false)
            {
                break;
            }
            else if (xCardDrawnBySecondPlayer == true && xCardDrawnByFirstPlayer == false)
            {
                break;
            }
            if (playerOneScore > playerTwoScore)
            {
                playerOneGamesWon++;
                playerOneTotalScore += playerOneScore;                
            }
            if (playerTwoScore > playerOneScore)
            {
                playerTwoGamesWon++;
                playerTwoTotalScore += playerTwoScore;
            }
        }
        if (xCardDrawnByFirstPlayer == true && xCardDrawnBySecondPlayer == false)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
        }
        else if (xCardDrawnBySecondPlayer == true && xCardDrawnByFirstPlayer == false)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");
        }
        else if (playerOneTotalScore > playerTwoTotalScore)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: " + playerOneTotalScore);
            Console.WriteLine("Games won: " + playerOneGamesWon);
        }
        else if (playerTwoTotalScore > playerOneTotalScore)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: " + playerTwoTotalScore);
            Console.WriteLine("Games won: " + playerTwoGamesWon);
        }
        else
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: " + playerOneTotalScore);
        }
    }
}

