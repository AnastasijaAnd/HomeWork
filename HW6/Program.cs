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
                TaskDZ6z1();
                break;
            case "2":
                TaskDZ6z2();
                break;
            case "out":
                isWork = false;
                break;
        }
    }
}
Main();

/* ДЗ6 1.Пользователь вводит с клавиатуры M
чисел. Посчитайте, сколько чисел больше 0 ввёл
пользователь.*/

void TaskDZ6z1()
{
int size = InputMessage($"Введите длину массива:  ");
int [] arrey = MakeArrayEnteringNumbers(size);
PrintArray(arrey);
int sum = SumPositiveNumbers(arrey);
Console.WriteLine($"В массиве {sum} чисел больше нуля.");
}

int[] MakeArrayEnteringNumbers(int size)
{
int [] nambers = new int[size];
for (int i = 0; i < size; i++)
    {
        int number = InputMessage($"Введите число {i + 1}: ");
        nambers[i] = number;
    }
    return nambers;
}

int SumPositiveNumbers (int [] arrey)
{
    int count =0;
    for (int i =0; i<arrey.Length;i++)
        {
            if (arrey[i]>0)
            {
                count++;
            }
        }
    return count;
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

/* ДЗ6 2. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями 
y =k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.*/
// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;
// Console.WriteLine($"Точка пересечения: ({x}, {y})");

void TaskDZ6z2()
{
int b1 = InputMessage("Введите значение b1: ");
int k1 = InputMessage("Введите значение k1: ");
int b2 = InputMessage("Введите значение b2: ");
int k2 = InputMessage("Введите значение k2: ");

if (MaybeCrossLine(b1, k1, b2, k2))
{
    Console.WriteLine($"Прямые пересекаются в точке [{string.Join(", ", CrossingCoordinate(b1, k1, b2, k2))}]");
}     
}

bool MaybeCrossLine(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            System.Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            System.Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

double[]CrossingCoordinate (double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];
    array[0] = (b2 - b1) / (k1 - k2);
    array[1] = k1 *((b2 - b1) / (k1 - k2)) + b1;
    return array;
}


