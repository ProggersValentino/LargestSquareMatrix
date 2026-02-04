using largestsquarematrix;



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] initArr = { "0111", "1111", "1111", "1111" };

LargestSqaureMatrixUtility.LargestSquareMatrix(initArr);

Console.WriteLine($"The largest square that can be found in the matrix is: {LargestSqaureMatrixUtility.highestSquare}; with an area of: {LargestSqaureMatrixUtility.ReturnAreaOfLargestSquare(LargestSqaureMatrixUtility.highestSquare)}");
