// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
System.Console.WriteLine("Введите число 8");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA == 8)
{
    int[] array = new int[numberA];

    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write(array[i] + " ");
    }
}
else
{
    System.Console.WriteLine("Ввели число больше 8");
}
