// /* ДЗ3 ЗАДАЧА 3 Программа, принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.*/


int x = IfNumber("Введите число:   ");

System.Console.WriteLine(string.Join("  ", Cube(x)));

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

int [] Cube(int x)
{  if (x < 0)
    {   
        x = -x; 
        int [] T = new int [x + 2];
        for (int i = 0; i < x + 2; i++)
        {
            T[i] = (int)Math.Pow(1-i, 3); 
        }
        return T;
    }
    else if (x == 0)
    {    
        int [] T = new int [x + 2];
        for (int i = 0; i < x + 2; i++)
        {
            T[i] = (int)Math.Pow(1-i, 3);  
        }
        return T;
    }

    int [] S = new int [x];
    for (int i = 0; i < x; i++)
    {
       S[i] = (int)Math.Pow(i+1, 3); 
    }
    return S;
}


