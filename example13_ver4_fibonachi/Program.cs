﻿// функция фибоначи f(n) = f(n-1)+f(n-2); f(1)=1; f(2)=2;
int Fibonacci(int n)
{
    if(n == 1 || n ==2)  return 1; // если n равно 1 или 2
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i<40; i++)
{
Console.WriteLine(Fibonacci(i));
}