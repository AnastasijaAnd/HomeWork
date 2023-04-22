/* ДЗ5 2.Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов с
нечётными индексами.*/

int size = InputMessage($"Введите длину массива:  ");
int minValue = InputMessage($"Введите минимальное значение для диапазона случайного числа:  ");
int maxValue = InputMessage($"Введите максимальное значение для диапазона случайного числа:  ");
int [] arrey = CreateArray(size,minValue,maxValue);
PrintArray(arrey);
int summa = SumNumbersWithUnevenIndex(arrey);
System.Console.WriteLine($"Сумма элементов с нечетными индексами в массиве {summa}.");


int SumNumbersWithUnevenIndex (int [] arrey)
{
    int count =0;
    for (int i =0; i<arrey.Length;i++)
        {
            if (i%2!=0)
            {
                count=count+arrey[i];
            }
        }
    return count;
}

int [] CreateArray(int size,int minValue, int maxValue)
{
int [] nambers = new int[size];
maxValue++;   
Random rnd = new Random();
for (int i = 0; i < size; i++)
    {
        nambers[i] = rnd.Next(minValue,maxValue);
    }
    return nambers;
}

void PrintArray(int[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
{
Console.Write($"{numbers[i]} ");
}
Console.WriteLine();
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

