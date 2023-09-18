int Factorial(int n)
{
    if(n==1) return 1; // факториал 1 это 1
    else return n* Factorial(n-1);
}
for (int i = 1; i<5; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");
}