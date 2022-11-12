/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

int number;
Console.WriteLine("|------Задача 6-------|");

Console.Write("Введите число:-> ");
number = Convert.ToInt32(Console.ReadLine());

PrintPower(number);

void PrintPower(int number_1)
{
    if (number_1 % 2 == 0)
    {
        Console.WriteLine($"Число {number_1} четное!");
    }
    else
    {
        Console.WriteLine($"Число {number_1} нечетное!");
    }
}