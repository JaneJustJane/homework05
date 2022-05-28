// Показать двумерный массив размером m×n заполненный вещественными числами

void FillArray (double [,] m1)
{
    for (int i=0; i<m1.GetLength(0);i++)
    {
        for (int j=0; j<m1.GetLength(1);j++)
        {
            m1[i,j]= Math.Round(new Random().NextDouble()*100,2);
        }
    }
}

void PrintArray (double [,] m2)
{
    for (int i=0; i<m2.GetLength(0); i++)
    {
        for (int j=0; j<m2.GetLength(1); j++)
        {
            Console.Write ($"{m2[i,j]}   ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("введите число m ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine() ?? "0");
double [,] matrix = new double [m,n];

FillArray (matrix);
PrintArray (matrix);