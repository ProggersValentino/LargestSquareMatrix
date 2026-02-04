using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestsquarematrix
{
    internal class LargestSqaureMatrixUtility
    {
        static int highestSquare = 0;

        public static void LargestSquareMatrix(string[] strArr)
        {
            //if 1 count up else reset to 0 
            //if number of 1s in row is greater 1 check rows below for same pattern
            //if row/s are valid increase highestSquare by 1



            int onesInARow = 0;

            //rows
            for (int i = 0; i < strArr.Length; i++)
            {
                //int onesStreakThisRow = 0;
                //individual numebrs
                for (int k = 0; k < strArr[i].Length; k++)
                {
                    Console.WriteLine(strArr[i][k]);




                    int rowSweeperIndx = k;
                    int currentHighestWithRow = 0;
                    //Console.WriteLine(strArr[i][rowSweeperIndx]);
                    onesInARow = 0;

                    while (rowSweeperIndx < (strArr[i].Length))
                    {
                        //if its not one then break out of the while  
                        if (strArr[i][rowSweeperIndx] != '1')
                        {
                            currentHighestWithRow = onesInARow;
                            break;
                        }

                        onesInARow++;

                        //if there is more than 1 in a row then it indicates a valid 2x2 square which is the minimum that can be done
                        if (onesInARow < 2)
                        {
                            rowSweeperIndx++;
                            continue;
                        }

                        int localizedOnesInARow = onesInARow - 1;

                        int expectedNumberOfOnesAccountedFor = onesInARow * onesInARow;
                        int numberOfOnesAccountedFor = onesInARow; //if its a perfect square then the amount of 1s for a valid square is to the power of 2 i.e. onesInARow = 2,
                                                                   //therefore numberOfOnesAccountedFor = 4

                        //we check the amount of rows below so we take one away cause we've already checked one row
                        for (int p = i + 1; p < onesInARow; p++)
                        {
                            //check this currrent row
                            for (int j = rowSweeperIndx - localizedOnesInARow; j <= rowSweeperIndx; j++)
                            {
                                Console.WriteLine($"Checking if on row: {p}; pos: {j}; {strArr[p][j]}; is equal to {strArr[i][j]}");
                                if (strArr[p][j].Equals(strArr[i][j]))
                                {
                                    numberOfOnesAccountedFor++;
                                }
                            }
                        }

                        Console.WriteLine($"the expected count was: {expectedNumberOfOnesAccountedFor} and the amount tracked {numberOfOnesAccountedFor}");

                        //have we accounted for all ones? if false break from the while loop
                        if (numberOfOnesAccountedFor != expectedNumberOfOnesAccountedFor)
                        {
                            break;
                        }

                        currentHighestWithRow = onesInARow;

                        rowSweeperIndx++;

                    }

                    //do we have a new highest square? if so replace highestSquare with the new one
                    if (currentHighestWithRow > highestSquare)
                    {
                        highestSquare = currentHighestWithRow;
                        Console.WriteLine($"New Highest Square: {highestSquare}");
                    }
                    else
                    {
                        Console.WriteLine($"Highest Square remains at: {highestSquare}");
                    }




                }

            }

        }

        public static int ReturnAreaOfLargestSquare(int largestSquare)
        {
            return largestSquare * largestSquare;
        }
    }
}
