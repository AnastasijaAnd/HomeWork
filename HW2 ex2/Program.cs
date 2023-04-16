/*  ДЗ2 ЗАДАЧА 2 Программа, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.*/

int a = IfNumber("Введите число: ");
if (a>=100){
    Console.WriteLine($"третья цифра {NumberThree(a)}.");
}
else{
    Console.WriteLine($"третьей цифры в числе {a} нет.");
}


int NumberThree(int x)
{
    int three = x/100 % 10;
    return three;
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

