/* ДЗ3 Задача 1. Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.*/
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int degreeBase = InputMessage("Введите число А:   ");
int exponent = InputMessage("Введите число В:   ");

if (IfCorrectExponent(exponent))
{
    Console.WriteLine($"Число {degreeBase} в степени {exponent} равно {Degree(degreeBase,exponent)}.");
}


int Degree(int degreeBase, int exponent)
{
    int degree =1;
    for (int i =0; i< exponent; i ++)
    {
        degree *= degreeBase;
    }
    return degree;
}

bool IfCorrectExponent(int exponent)
{
  if (exponent <0)
    {
        Console.WriteLine("Число В - показатель степени- не должен быть меньше 0.");
        return false;
    }  
    return true;
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

