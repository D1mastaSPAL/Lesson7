namespace Task2;

internal class Task2
{
    static void Main(string[] args)
    {
        int[,] matrix =
            {
                {-99, 19, 91,},
                {77, -55, 75,},
                {44, 43, -33,},
            };
        Console.Write("Двумерный массив: " + "\n");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        maxValueRowMethod(matrix);
    }

    public static void maxValueRowMethod(int[,] matrix)
    {
        int num = 0;
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            num++;
            int numberMax = 0;
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                if (y == 0 || numberMax < matrix[x, y]) numberMax = matrix[x, y];
            }
            Console.WriteLine($"Максимальное значение ряда {num}: {numberMax}");
        }
    }
}
