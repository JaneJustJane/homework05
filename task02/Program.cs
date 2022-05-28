// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillArray (int [,] m1)
{
    for (int i=0; i<m1.GetLength(0);i++)
    {
        for (int j=0; j<m1.GetLength(1);j++)
        {
            m1[i,j]=new Random().Next(0,10);
        }
    }
}

void PrintArray (int [,] m2)
{
    for (int i=0;i<m2.GetLength(0);i++)
    {
        for (int j=0; j<m2.GetLength(1); j++)
        {
            Console.Write($"   {m2[i,j]}   ");
        }
    Console.WriteLine();
    }
}

void ChangeArray (int [,] m3)
{
    for (int i=0; i<m3.GetLength(0); i++)
    {
        for (int j=0; j<m3.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)
            m3[i,j]=m3[i,j]*m3[i,j];
        }
    }
}

Console.WriteLine();
Console.Write("введите кол-во строк массива ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("введите кол-во столбцов массива  ");
int b = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix = new int [a,b];
Console.WriteLine();
Console.WriteLine("Дан массив, который надо изменить:");
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Новый массив: элементы, у которых оба индекса четные, заменены на их квадраты:");
ChangeArray(matrix);
PrintArray(matrix);