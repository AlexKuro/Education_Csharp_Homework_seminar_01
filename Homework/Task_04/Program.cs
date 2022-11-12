/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int numberFirst, numberSecond, numberThird;

Console.WriteLine("|------Задача 4-------|");

Console.Write("Введите первое число:-> ");
numberFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:-> ");
numberSecond = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число:-> ");
numberThird = Convert.ToInt32(Console.ReadLine());

PrintPower(numberFirst, numberSecond, numberThird);

void PrintPower(int number_1, int number_2, int number_3)
{
    int max;
    if ( number_1 > number_2)
    {
        max = number_1; 
    }
    else
    {
        max = numberSecond;      
    }

    if (number_3 > max)
    {
        max = number_3;     
    }

Console.WriteLine($" max = {max}");
}