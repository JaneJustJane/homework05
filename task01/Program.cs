// Задать двумерный массив следующим правилом: Aₘₙ = m+n

void PrintArray (int [,] m1)
{
    for (int i=0; i<m1.GetLength(0); i++)
    {
        for (int j=0; j<m1.GetLength(1); j++)
        {
            Console.Write($"{m1[i,j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите кол-во столбцов n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int [,] matrix = new int [m,n];
for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j]=i+j;
    }

}
PrintArray (matrix);