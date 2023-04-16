/*  ДЗ2 ЗАДАЧА 3 Программа, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/


int weekday = IfNumber("Введите цифру, обозначающую день недели (1-7): ");

for (; weekday<1 || weekday>7;)
{
    Console.WriteLine($"Вы ввели цифру, не обозначающую день недели, поэтому повторите ввод, пожалуста, (1-7):  ");
    int b = IfNumber("");
    weekday= b;
}
switch (weekday)
    {
        case 1:
            System.Console.WriteLine("понедельник - это рабочий день.");
            break;
    
            case 2:
            System.Console.WriteLine("вторник - это рабочий день.");
            break;
            
            case 3:
            System.Console.WriteLine("среда - это рабочий день.");
            break;

            case 4:
            System.Console.WriteLine("четверг - это рабочий день.");
            break;

            case 5:
            System.Console.WriteLine("пятница - это рабочий день.");
            break;

            case 6:
            System.Console.WriteLine("суббота - это выходной день.");
            break;

            case 7:
            System.Console.WriteLine("воскресение - это выходной день.");
    
        return;  
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


