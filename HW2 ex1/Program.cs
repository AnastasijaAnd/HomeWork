/* ДЗ2 ЗАДАЧА 1 Программа, принимает на вход трехзначное число 
и на выходе показывает вторую цифру этого числа.*/

int a = IfNumber("Введите трехзначное число: ");
for (; a<100 || a>=1000;)
{
    Console.WriteLine($"Вы ввели не трехзначное число, поэтому повторите ввод, пожалуста:  ");
    int b = IfNumber("");
    a= b;
}
for (; a>=100 || a<1000;) 
{
    Console.WriteLine($"вторая цифра числа: {Second(a)}.");
    break;
}


int Second(int x)
{
	int second = x/10 % 10;
    return second;
}

int IfNumber(string argument)
{
    Console.Write(argument);
    int m;
    while (!int.TryParse(Console.ReadLine(), out m))
    {
        Console.WriteLine("Это не число, поэтому повторите ввод, пожалуста:  ");
        int a;   
        if (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Это не число, поэтому повторите ввод, пожалуста:  ");
        }
        else
        {
            return m = a;
        }
   }
    return m;
}


