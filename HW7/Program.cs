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
                Dz7z1();
                break;
            case "2":
                Dz7z2();
                break;
            case "3":
                Dz7z3();
                break;
            case "out":
                isWork = false;
                break;
        }
    }
}
Main();


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


/* ДЗ7 1. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.*/
void Dz7z1()
{
int m = InputMessage($"Введите количество строк:  ");
int n = InputMessage($"Введите количество столбцов:  ");
CreateAndPrintDoubleRandomArray(m, n);
}

void CreateAndPrintDoubleRandomArray(int m=10, int n=10,int minValue=-10, int maxValue=10)
{
    Random x = new Random();
    maxValue++;
    double[,] array = new double[m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double add = Math.Round(Convert.ToDouble(x.Next(minValue*10, maxValue*10)/10.00),2);
            array[i, j] = add;
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}    ");
        }
        System.Console.WriteLine();
    }
}


/* ДЗ7 2. Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
или же указание,что такого элемента нет.*/
void Dz7z2()
{
Console.Write("Введите позицию элемента в двумерном массиве в формате i,j: ");
string input1 = Console.ReadLine();
string[] splitInput1 = input1.Split(',');
int i = int.Parse(splitInput1[0]);
int j = int.Parse(splitInput1[1]);
ElementValue(i,j);
}

void ElementValue(int i, int j)
{
    int [,]array = CreateMatrix();
    PrintMatrix(array);
    if (i>=array.GetLength(0)|| j>=array.GetLength(1))
    {
       Console.WriteLine($"В массиве нет значения для данной позиции."); 
    }
    if (i<array.GetLength(0)|| j<array.GetLength(1)) 
    {
     Console.WriteLine($"Значение элемента массива в позиции ({i},{j}) равно {array [i,j]}.");
    }
}

int [,] CreateMatrix(int a=5, int b=4)
{
    Random rnd = new Random();
    int[,] arr = new int[a, b];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int add = rnd.Next(1, 10);
            arr[i, j] = add;
        }
    }
    return arr ;
}

void PrintMatrix(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}


/* ДЗ7 3. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.*/
void Dz7z3()
{
    int [,]array = CreateMatrix();
    PrintMatrix(array);
    AverageInColumb(array);
}

void AverageInColumb( int [,]array)
{
    double c=array.GetLength(0);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summa =0;
        for (int i= 0; i <array.GetLength(0); i++)
        {
            summa +=array[i,j];
        }
        Console.WriteLine($"Среднее арифметическое в столбце {j+1} = {Math.Round(summa/c,2)}.");
    }
}


