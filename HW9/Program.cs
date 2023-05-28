

void Main()
{
    bool isWork = true;

    while (isWork)
    {
        Console.WriteLine("Введите номер задачи: ");
        string command = Console.ReadLine();

        switch (command)
        {
            case "1":
                DZ9Z1Task64();
                break;
            case "2":
                DZ9Z2Task66();
                break;
            case "3":
                DZ9Z3Task68();
                break;        
            case "out":
                isWork = false;
                break;
        }
    }
}
Main();

/*Задача 64: Задайте значения M и N.
 Напишите программу, которая выведет
 все натуральные числа в промежутке от M до N.*/
void DZ9Z1Task64()
{
    int m = InputMessage($"Введите число M:  ");
    int n = InputMessage($"Введите число N:  ");
    System.Console.WriteLine(NumbersRec1(m, n));
}
string NumbersRec1(int m, int n)
{
    if (m <= n ) return $"{m} " + NumbersRec1(m + 1, n);
    else return String.Empty;
}

/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.*/
void DZ9Z2Task66()
{
    int m = InputMessage($"Введите число M:  ");
    int n = InputMessage($"Введите число N:  ");
    Console.WriteLine($"Сумма натуральных чисел промежутка [{m},{n}] равна {SummRec(m, n)}");
}

int SummRec(int m, int n)
{
    int sum = 0;
    if (m <= n ) return sum=m+ SummRec(m+1,n);     
    return sum;
}

/* Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.*/
void DZ9Z3Task68()
{
    int m = InputMessage($"Введите неотрицательное число m:  ");
    int n = InputMessage($"Введите неотрицательное число n:  ");
    Console.WriteLine($"Функция Аккермана для чисел m={m} и n={n} равна {AkkermRec(m, n)}");
}

int AkkermRec(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkermRec(m - 1, 1);
    else return AkkermRec(m - 1, AkkermRec(m, n - 1));
}


int InputMessage(string message)
{
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
