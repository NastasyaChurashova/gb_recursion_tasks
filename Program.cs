// ****Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

void DisplayFromMtoN(int m, int n)
{
    if (m > n)
    {
        DisplayFromMtoN(m - 1, n);
        System.Console.WriteLine(m + " ");

    }
    else if (n > m)
    {
        DisplayFromMtoN(m, n - 1);
        System.Console.WriteLine(n + " ");
    }
    else System.Console.WriteLine(m);

}
DisplayFromMtoN(5, 1);

// ****Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}
System.Console.WriteLine(AkkermanFunction(1, 1));

// ****Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArrayFromEnd(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }
    System.Console.WriteLine(array[index] + " ");
    PrintArrayFromEnd(array, index - 1);
}

int[] createdArray = CreateArray(7, 5, 55);

PrintArrayFromEnd(createdArray, createdArray.Length - 1);