/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
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

void PrintArray(int[] array)
    {
        int counts = array.Length;
        int position = 0;
        while (position < counts)
            {
                Console.Write($"{array[position]} ");
                position++;
            }
    }

int NomerStroki (int[,] arr1) // номер строки с минимальным значением
{
    int NumStr=0;
    int sumStr=0;
    //int TempMin=0;
    int TempStr=0;
    int [] arrSum = new int [arr1.GetLength(0)];
    for (int i=0; i<arr1.GetLength(0);i++)
    {
        sumStr=0;
        for (int j=0; j<arr1.GetLength(1);j++)
        {
            sumStr=sumStr+arr1[i,j];
        }
        
        arrSum[i]=sumStr;
        
    }
    
    for (int i=0; i<arrSum.Length-1;i++)
    {
        

        if (arrSum[i]<arrSum[i+1]) 
            {
                NumStr=i;
            }
    }
        
    
PrintArray(arrSum);
Console.WriteLine("");
return NumStr;
}
Console.WriteLine("введите размерность двумерного массива, 2 числа через запятую");
string input=Console.ReadLine();
string[] arrayInput =input.Split(',');
int [,] array = new int [Convert.ToInt32(arrayInput[0]),Convert.ToInt32(arrayInput[1])];
FillArray (array);
PrintArrayRazm(array);
Console.WriteLine("");
Console.WriteLine("номер строки с наименьшей суммой элементов: "+NomerStroki(array));