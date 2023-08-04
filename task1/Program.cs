// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[num];

void PrintArray(int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int FindCount(int[] Array)
{
    int i = 0;
    int count = 0;
    while (i < Array.Length)
    {
        if (Array[i] > 0)
            count++;
        i++;
    }
    return count;
}

PrintArray(num);
Console.Write($"Чисел больше нуля: {FindCount(Array)}");