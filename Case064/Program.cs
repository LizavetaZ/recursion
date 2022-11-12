﻿int M = InputValue("Введите первое число"); //задача Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
int N = InputValue("Введите второе число");
if (IsInputValidate(M, N))
{
    Console.WriteLine (NumbersRec(M, N));
}
else Console.WriteLine("Ошибка вводимых данных");

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = int.Parse(value);
    return a;
}

bool IsInputValidate(int a, int b)
{
    if (a < b)
        return false;
    return true;
}

string NumbersRec (int a, int b)
{
    if (a>=b) 
    {
        string temp = NumbersRec(a-1, b);    
        return $"{a} " + temp;  
    } 
    else return String.Empty;
}
