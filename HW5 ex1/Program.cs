/* ДЗ5 1.Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.*/

int size = InputMessage($"Введите длину массива:  ");
int [] arrey = CreateArray(size);
PrintArray(arrey);
int count = CountEvenNumbers (arrey);
System.Console.WriteLine($"Количество четных чисел в массиве {count}.");


int CountEvenNumbers (int [] arrey)
{
    int count =0;
    for (int i =0; i<arrey.Length;i++)
        {
            if (arrey[i]%2==0)
            {
                count++;
            }
        }
    return count;
}

int [] CreateArray(int size,int minValue=100, int maxValue=999)
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

