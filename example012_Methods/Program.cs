// 1 вид

void Method1()
{
    System.Console.WriteLine("Автор...");
}

//Method1();

// 2 вид

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("message text");

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

//int year = Method3();
//Console.WriteLine(year);

//Вид 4

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result  = String.Empty;

//     while (i<count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string c)
{
    string result  = String.Empty;
    for (int i = 0; i < count; i++) 
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "a");
Console.WriteLine(res);