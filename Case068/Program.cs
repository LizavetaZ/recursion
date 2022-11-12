int M = InputValue("Введите первое число"); //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int N = InputValue("Введите второе число");
if (IsInputValidate(M, N))
{
    Console.WriteLine(Akerman(M, N));
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
    if (a <= 0 || a > 3 || b <= 0)                              //очень не уверена, но по условию 0 ≤ m ≤ 3
        return false;
    return true;
}

int Akerman(int m, int n)                                       //n+1   m=0
{                                                               //m-1,1 m>0,n=0
    if (m == 0)                                                 //m-1,A(m,n-1) m>0,n>0
    {
        return n + 1;
    } 
    else if (n == 0 && m > 0)
    {
        return Akerman(m - 1, 1);
    } 
    else 
    {
        return Akerman(m - 1, Akerman(m, n - 1));
    }
}

