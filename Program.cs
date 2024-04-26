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