namespace Lesson7._1;

internal class Task1
{
    static void Main(string[] args)
    {
        int[] ArrayInputConsole = new int[6];
        Console.WriteLine($"Заполните одномерный массив {"\n"}");
        int num = 1;
        for (int i = 0; i < ArrayInputConsole.Length; i++)
        {
            Console.WriteLine($"Введите число {num++}: ");
            var inputNumbers = Console.ReadLine();

            if (int.TryParse(inputNumbers , out var count) && count > 0)
            {
                ArrayInputConsole[i] = count;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                return;
            }
        }
        Array.Sort(ArrayInputConsole);
        Array.Reverse(ArrayInputConsole);
        Console.Write($"Обратный порядок введенных вами чисел в отсортированном массиве: {"\n"}");
        foreach (var outputNumbers in ArrayInputConsole)
        {
            Console.Write(outputNumbers + "\t");
        }
    }
}
