using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[8, 16];
        int pigsCount = 0;
        //Filling the matrix and counting how many pigs needs to be destroyed to win the game
        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 16; j++)
            {
                matrix[i, j] = Convert.ToInt32((number >> j) & 1);
                if (j < 8 && (matrix[i, j] == 1))
                {
                    pigsCount++;
                }
            }
        }
        int totalCount = 0; //holds the total points made
        int destroyedPigs = 0; //holds the count of the destroyed pigs
        //one loop to iterate through the columns of the left side of the matrix (where the birds are)
        for (int col = 8; col < 16; col++)
        {
            //one loop to iterate through the rows of the left side of the matrix and to check
            //cell by cell if there is a bird
            for (int row = 0; row < 8; row++)
            {
                //if there is a bird (current cell is equal to 1)
                if (matrix[row, col] == 1)
                {
                    int cellRow = row; //used to copy row so we can change the value
                    int cellCol = col; //used to copy col so we can change the value
                    matrix[row, col] = 0; //we make the bird 0 because we have to remove it from the game
                    string direction = "up"; //specify the direction up or down
                    int counter = 0; //count how many position we have moved the bird
                    //the while(true) loop is used to "throw" the bird (increase it's row and 
                    //col indexes until 1 is found or until the bird hits the bottom or the side of the matrix
                    while (true)
                    {
                        //if we find a pig on the right side of the matrix we go into the body of the if statement
                        if ((matrix[cellRow, cellCol] == 1) && cellCol < 8)
                        {
                            matrix[cellRow, cellCol] = 0; //we destroy the pig by setting it to zero
                            destroyedPigs++;
                            int multiplyer = 1; //since the formula is calculated by destroyed pigs * the length of the flight we need a variable to see how many pigs we are destroying
                            //with this loop we count all the pigs around the pig that we just hit
                            //with all the breaks inside the loop we make sure that won't go of matrix and we will avoid index out of range exception
                            for (int i = cellCol + 1; i >= cellCol - 1; i--)
                            {
                                if (i == 8)
                                {
                                    i = 7;
                                }
                                for (int j = cellRow - 1; j <= cellRow + 1; j++)
                                {
                                    if (j == -1)
                                    {
                                        j = 0;
                                    }
                                    //since we counted 2 positions out of the nine we skip them with continue
                                    if ((i == cellCol && j == cellRow) || (i == cellCol + 1 && j == cellRow - 1))
                                    {
                                        if (j + 1 == 8) break;
                                        if (i - 1 == -1) break;
                                        continue;
                                    }
                                    else
                                    {
                                        //if we find a pig around the pig that we destroyed we set it to 0 and we count it
                                        if (matrix[j, i] == 1)
                                        {
                                            matrix[j, i] = 0;
                                            destroyedPigs++;
                                            multiplyer += 1;
                                        }
                                    }
                                    if (j + 1 == 8) break; 
                                }
                                if (i - 1 == -1) break;
                            }
                            //after we check how many pigs we have around our destroyed pig we put them in the variable multiplyer and we multiply it by the positions changed during the fly
                            totalCount += multiplyer * counter;
                            counter = 0;
                            break; //after we destroy the pig and pigs around it we break the loop and after that we go back to find an other bird
                        }
                        if (direction == "up") //if the bird reaches the top of the matrix we change it's direction to down
                        {
                            if (cellRow == 0)
                            {
                                direction = "down";
                                cellCol--;
                                cellRow++;
                            }
                            else
                            {
                                cellRow--;
                                cellCol--;
                            }
                        }
                        else if (direction == "down") //if the bird is flying down and it reaches the right or the bottom of the matrix we break the loop
                        {
                            if (cellCol == 0 || cellRow == 7)
                            {
                                break;
                            }
                            cellRow++;
                            cellCol--;
                        }
                        counter++; //after each movement we make with the bird we increase the counter
                    }
                }
            }
        }
        Console.Write(totalCount);
        if (destroyedPigs == pigsCount) // if we have destroyed as many pigs as there are in the game we say they we won
        {
            Console.WriteLine(" Yes");
        }
        else
        {
            Console.WriteLine(" No");    
        }
    }
}

