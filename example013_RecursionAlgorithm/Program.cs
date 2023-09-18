// string [,] table = new string [2, 5];
// table [1,2] = "слово";

// for (int rows = 0; rows<2; rows++) // для печати массива
// {
//     for (int columns = 0; columns<5; columns++)
//     {
//         Console.WriteLine($"{table[rows,columns]}-");
//     }
// }

int[,] matrix = new int [3,4];

void PrintArray(int[,] matr)
{
for (int i = 0; i<matr.GetLength(0); i++) // считывает длинну строк при помощи метода
{
    for (int j=0; j<matr.GetLength(1); j++) // считывает длину столбца при помощи метода
    {
        Console.Write($"{matr[i,j]} ");
    }   
     Console.WriteLine(); // принудительный перевод на новую строку после полной печати строки 
}
}

void FillArray(int[,] matr)
{
  for (int i = 0; i<matr.GetLength(0); i++) // считывает длинну строк при помощи метода
{
    for (int j=0; j<matr.GetLength(1); j++) // считывает длину столбца при помощи метода
    {
        matr[i,j] = new Random().Next(1,10); //обращаемся к каждому элементу и вызываем генератор случайных чисел 
    }   
     Console.WriteLine(); // принудительный перевод на новую строку после полной печати строки 
}  
}

PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);