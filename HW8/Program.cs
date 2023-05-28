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
                DZ8Z1Task54();
                break;
            case "2":
                DZ8Z1Task56();
                break; 
            case "3":
                DZ8Z1Task58();
                break;
            case "4":
                DZ8Z1Task60();
                break;
            case "5":
                DZ8Z1Task62();
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

int [,] CreateMatrix(int m, int n)
{
    Random rnd = new Random();
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int add = rnd.Next(1, 10);
            matrix[i, j] = add;
        }
    }
    return matrix ;
}

void PrintMatrix(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

/*Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.*/

void DZ8Z1Task54()
{
int m = InputMessage($"Введите количество строк:  ");
int n = InputMessage($"Введите количество столбцов:  ");
int [,] matrix = CreateMatrix(m,n);
PrintMatrix(matrix);
SortRowsInDescendingOrder(matrix);
}

void SortRowsInDescendingOrder (int [,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            for (int a = j+1; a < matrix.GetLength(1); a++)
            {
               if(matrix[i,a] > matrix[i, j])
                {
                    int temp = matrix[i,j];
                    matrix[i,j] = matrix[i,a];
                    matrix[i, a] = temp;
                }   
            }       
        }
    }
    System.Console.WriteLine();
    PrintMatrix(matrix);
}   
  
/*Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.*/

void DZ8Z1Task56()
{
int m = InputMessage($"Введите количество строк (столбцов) прямоугольной матрицы:  ");
int n = m;
int [,] matrix = CreateMatrix(m,n);
PrintMatrix(matrix);
StringSumm(matrix);
Console.WriteLine($"Cуммы: ");
Console.WriteLine($"{string.Join(" ", StringSumm(matrix))}");
RowWithMinSum(StringSumm(matrix));
}

void RowWithMinSum(int [] array)
{
    int index = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) index = i;
    }
    Console.WriteLine($"{index+1} - строка с наименьшей суммой элементов.");
}
   
int [] StringSumm(int [,] matrix)
{
    int[] arraySumm = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum =0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum +=matrix[i,j];
        }
        arraySumm[i] = sum;
    }
    return arraySumm;
}

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.*/

void DZ8Z1Task58()
{
int m = InputMessage($"Введите количество строк первой матрицы:  ");
int n = InputMessage($"Введите количество столбцов первой матрицы:  ");
int a = InputMessage($"Введите количество строк второй матрицы:  ");
int b = InputMessage($"Введите количество столбцов второй матрицы:  ");
int [,] matrix = CreateMatrix(m,n);
PrintMatrix(matrix);
System.Console.WriteLine();
int [,] matr = CreateMatrix(a,b);
PrintMatrix(matr);
if(CanMultiply(matrix,matr))
    {
        Console.WriteLine();
        int[,] array = MatrixProduct(matrix, matr);
        PrintMatrix(array);
    }
}

bool CanMultiply(int[,] matrix, int[,] matr) 
{
    return matrix.GetLength(0) == matr.GetLength(1);
}

int[,] MatrixProduct(int[,] matrix, int[,] matr)
{
    int[,] array = new int[matrix.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            array[i,j] = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                array[i,j] += matrix[i,k] * matr[k,j];
            } 
        }
    }
    return array;
}

/*Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.*/

void DZ8Z1Task60()
{
int m = InputMessage($"Введите количество строк матрицы:  ");
int n = InputMessage($"Введите количество столбцов матрицы:  ");
int a = InputMessage($"Введите количество слоев матрицы:  ");

int [,,] cubmatrix = CreateCubMatrixWithNonRepeatingNumbers(m,n,a);
PrintCubMatrixWithIndexInRow(CreateCubMatrixWithNonRepeatingNumbers(m,n,a));
System.Console.WriteLine();
}

int [,,] CreateCubMatrixWithNonRepeatingNumbers(int m, int n, int a)
{
    Random rnd = new Random();
    int[,,] cubmatrix = new int[m, n, a];
    Dictionary<int, int> dict = new Dictionary<int, int>();
    for (int i = 0; i < cubmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < cubmatrix.GetLength(1); j++)
        {
            for (int k = 0; k < cubmatrix.GetLength(2); k++)
            {
                int add = rnd.Next(10, 100);
                cubmatrix[i, j, k] = add;
                while (dict.ContainsKey(cubmatrix[i, j, k])) 
                {
                    cubmatrix[i, j, k] = new Random().Next(10, 100);
                }
                dict.Add(cubmatrix[i, j, k], 1);
            }
        }
    }
    return cubmatrix;
}


 void PrintCubMatrixWithIndexInRow(int [,,] cubmatrix)
{
    for (int i = 0; i < cubmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < cubmatrix.GetLength(1); j++)
        {
           for (int k = 0; k < cubmatrix.GetLength(2); k++)
            {
                Console.Write(($"{cubmatrix[i, j, k]}({i},{j},{k})  "));
            }
            Console.WriteLine();
        }
    }
}

/*Задача 62: Заполните спирально массив 4 на 4.*/

void DZ8Z1Task62()
{
int m = InputMessage($"Введите размер квадратного массива:  ");
int n =m;
int [,] helix = new int[m, n];
Helixmassive(helix);
}
 
 int[,] Helixmassive (int [,] array)
 {
    array[0,0] = 1;
    int size = array.GetLength(0);
    int n = 0;
    while(n != size/2)
    {
        for(int i = n; i < size-n; i++) //верх слева-направо
        {
            if(n == 0)
            {
                for(int j = 1; j < size-n; j++)
                {
                    array[i,j] = array[i,j-1]+1;
                }
            }
            else{
                for (int j = n; j < size-n; j++)
                {
                    array[i,j] = array[i,j-1]+1;
                }
            }
        }
        for (int i = n + 1; i < size-n; i++) //правая граница сверху вниз
        {
            for (int j = size-n-1; j > n; j--)
            {
                array[i,j] = array[i-1,j]+1;
            }
        }
        for(int i = size-n-1; i > n; i--) //низ справа-налево
        {
            for (int j = size-n-2; j >= n; j--)
            {
                array[i,j] = array[i,j+1]+1;
            }
        }
        for (int i = size-n-2; i > n; i--) //левая граница снизу вверх
        {
            for (int j = n; j < size-n-1; j++)
            {
                array[i,j] = array[i+1,j]+1;
            }
        }

    n++;
    }
    PrintMatrix(array);         
    return array;
 }


