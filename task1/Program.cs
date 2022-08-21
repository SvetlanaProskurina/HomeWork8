/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8*/

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
void PrintArrayRazm(int[,] array)
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

int [,] PoVozrastaniyu (int[,] arr1)
{
    
    //int [,] arr2 = new int [arr1.GetLength(0),arr1.GetLength(1)];
    for (int i=0; i<arr1.GetLength(0);i++)
    {
        for (int f=0; f<arr1.GetLength(0);f++)
        for (int j=0; j<arr1.GetLength(1)-1;j++)
        {
           if (arr1[i,j]> arr1[i,j+1]) 
           {
            int TempMin=arr1[i,j+1];
            arr1[i,j+1]=arr1[i,j];
            arr1[i,j]=TempMin;
           }
           
        }
    }
    return arr1;
}
Console.WriteLine("введите размерность двумерного массива, 2 числа через запятую");
string input=Console.ReadLine();
string[] arrayInput =input.Split(',');
int [,] array = new int [Convert.ToInt32(arrayInput[0]),Convert.ToInt32(arrayInput[1])];
FillArray (array);
PrintArrayRazm(array);
Console.WriteLine("");
PrintArrayRazm(PoVozrastaniyu (array));