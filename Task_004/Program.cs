Console.WriteLine("Введите количество строк и столбцов, соответственно");
int a = int.Parse(Console.ReadLine()?? "0");
int b = int.Parse(Console.ReadLine()?? "0");

void FillMass(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           numbers[i, j] = new Random().Next(10);
        }
    }
}

int MainLine(int[,] numbers)
{
    int c = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           if (i == j)
           {
            c = numbers[i, j] + c;
           }
        }
    }
    return c;
}

void PrintMass(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] numbers = new int[a, b];
FillMass(numbers);
MainLine(numbers);
PrintMass(numbers);
Console.WriteLine("Сумма элементов по главной диагонали равна {0}", MainLine(numbers));