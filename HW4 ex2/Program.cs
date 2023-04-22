/*Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.*/
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = InputMessage("Введите число:   ");
Console.WriteLine($"Сумма цифр в числе {number} равна {QuantityDigit(number)}.");


int QuantityDigit(int number)
{
    int summ =0;
    while (number > 0)
    {
        summ += number % 10;
        number = number / 10;
    }
    return summ;
}

int InputMessage(string message)
{
    // System.Console.WriteLine(message);
    int result = IfNumber(message);
    return result;
}

int IfNumber(string argument)
{
    Console.Write(argument);
    int m;
    while (!int.TryParse(Console.ReadLine(), out m))
    {
        Console.WriteLine("Это не число, поэтому повторите ввод, пожалуста:  ");
   }
    return m;
}


