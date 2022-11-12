/*Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

int number;
Console.WriteLine("|------Задача 8-------|");

Console.Write("Введите число:-> ");
number = Convert.ToInt32(Console.ReadLine());

PrintPower(number);

void PrintPower(int number_1)
{
    if (number_1 > 0)
    {  
        int count = 1;
        while (count <= number_1)
        {
            if (count % 2 == 0)
            {
                Console.Write($"{count} ");                   
            }
        count ++;
        }
    }
    else
    {
        Console.WriteLine($"Число {number_1} отрицательное, введите число > 0!");
    }
}
