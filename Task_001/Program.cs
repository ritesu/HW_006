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
PrintMass(numbers);