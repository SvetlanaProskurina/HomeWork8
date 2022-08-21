/*Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1,10);
            }
        }
}
void PrintArrayMatr(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
         for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
           
        }
        Console.WriteLine();
    }
}
/*Console.WriteLine("введите размерность матрицы, 2 числа через запятую");
string input=Console.ReadLine();
string[] arrayInput =input.Split(',');
int [,] matrix1 = new int [Convert.ToInt32(arrayInput[0]),Convert.ToInt32(arrayInput[1])];
FillArray (matrix1);
int [,] matrix2 = new int [Convert.ToInt32(arrayInput[0]),Convert.ToInt32(arrayInput[1])];
FillArray (matrix2);
PrintArrayMatr(matrix1);
PrintArrayMatr(matrix2);
Console.WriteLine("");*/
int [,] matrix1 = {{1, 4, 7, 2},
                   {5, 9, 2, 3},
                   {8, 4, 2, 4},
                   {5, 2, 6, 7}};
int [,] matrix2 = {{1, 5, 8, 5},
                   {4, 9, 4, 2},
                   {7, 2, 2, 6},
                   {2, 3, 4, 7}};

    int m = matrix1.GetLength(0);
    int n = matrix2.GetLength(1);
    int [,] matrixResultMath = new int [m,n];
    int [,] matrixResult = new int [m,n];
int [,] MultiplyArrayMath(int [,] array1, int [,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
        {   
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                matrixResult[i, j]=0;
                for (int s = 0; s < array2.GetLength(0); s++) 
                        {
                                                     
                                matrixResultMath[i, j]+= array1[i,s]*array2[s,j];
              
                        }
            }
        }
        return matrixResultMath;
}
int [,] MultiplyArray(int [,] array1, int [,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
        {   
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                matrixResult[i, j]+= array1[i,j]*array2[i,j];
            }
        }
        return matrixResult;
}
Console.WriteLine("перемножение матриц по правилам математики");
PrintArrayMatr(MultiplyArrayMath(matrix1,matrix2));
Console.WriteLine("");
Console.WriteLine("простое перемножение соответствующих элементов матриц");
PrintArrayMatr(MultiplyArray(matrix1,matrix2));