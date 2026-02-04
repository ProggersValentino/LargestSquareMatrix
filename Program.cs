// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] initArr = { "01000", "11111", "01111", "11111" };
//indicates the highest possible square to be found 
int highestSquare = 0;



void LargestSquareMatrix(string[] strArr)
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

            if (strArr[i][k] != '1')
            {
                onesInARow = 0;
                continue;
            }

            onesInARow++;

            if (onesInARow < 2)
            {
                highestSquare = 1;
                continue;
            }

            Console.WriteLine(onesInARow);


            int localizedOnesInARow = onesInARow - 1;
            
            int expectedNumberOfOnesAccountedFor = onesInARow * onesInARow;
            int numberOfOnesAccountedFor = onesInARow; //if its a perfect square then the amount of 1s for a valid square is to the power of 2 i.e. onesInARow = 2,
                                                       //therefore numberOfOnesAccountedFor = 4

            //we check the amount of rows below so we take one away cause we've already checked one row
            for (int p = i + 1; p <= onesInARow; p++)
            {
                //check this currrent row
                for (int j = k - localizedOnesInARow; j <= k; j++)
                {
                    Console.WriteLine($"Checking if on row: {p}; pos: {j}; {strArr[p][j]}; is equal to {strArr[i][j]}");
                    if (strArr[p][j].Equals(strArr[i][j]))
                    {
                        numberOfOnesAccountedFor++;
                    }
                }
            }

            Console.WriteLine($"the expected count was: {expectedNumberOfOnesAccountedFor} and the amount tracked {numberOfOnesAccountedFor}");

            //have we accounted for all ones? if false restart and continue
            if (numberOfOnesAccountedFor != expectedNumberOfOnesAccountedFor)
            {
                onesInARow = 0;
                continue;
            }

            highestSquare = onesInARow;
            Console.WriteLine($"New Highest Square: {highestSquare}");

            

        }
    }

}

LargestSquareMatrix(initArr);
