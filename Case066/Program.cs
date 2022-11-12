int M = InputValue("Введите первое число"); //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int N = InputValue("Введите второе число");
if (IsInputValidate(M, N))
{
    Console.WriteLine(SumRec(M, N));
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
    if (a <= 0 || b <= 0 || a > b) // натуральные же
        return false;
    return true;
}

int SumRec(int a, int b)
{
    if (a == b)
        return b;
    else return a + SumRec(a + 1, b);
}

