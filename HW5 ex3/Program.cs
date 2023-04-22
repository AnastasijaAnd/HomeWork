/* ДЗ5 3.Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным элементами
массива.*/

int size = InputMessage($"Введите длину массива:  ");
int minValue = InputMessage($"Введите минимальное значение для диапазона случайного числа:  ");
int maxValue = InputMessage($"Введите максимальное значение для диапазона случайного числа:  ");
double[] DoubleArray = CreateDoubleArray(size, minValue, maxValue);
PrintArray(DoubleArray);
double MAX = SearchMaxNumber(DoubleArray);
Console.WriteLine($"Максимальный элемент массива {MAX}");
double MIN = SearchMinNumber(DoubleArray);
Console.WriteLine($"Минимальный элемент массива {MIN}");
Console.WriteLine($"{Math.Round(MAX - MIN,2)} - разница между максимальным и минимальным элементами массива.");


double SearchMaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double SearchMinNumber(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double[] CreateDoubleArray(int size, int minValue, int maxValue)
{
    maxValue++;
    double[] array = new double[size];
    Random x = new Random();
    for (int i = 0; i < size; i++)
    {
        // array[i] = Math.Round(rand.Next(minValue, maxValue) + rand.NextDouble(), 2);
        array[i] = Math.Round(Convert.ToDouble(x.Next(minValue*10, maxValue*10)/10.00),2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
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


