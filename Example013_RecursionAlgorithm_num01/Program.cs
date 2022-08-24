/// Пример с цифрами.
// int [,] matrix = new int [3,4];

// for (int i = 0; i < 3; i++ ) // по строкам либо можно использовать для поиска "matrix.GetLength(0)"
// {
//     for (int j = 0 ; j < 4; j ++) // внутренний по столбцам либо можно использовать для поиска "matrix.GetLength(1)"
//     {
//         Console.Write ($"{matrix[i, j]} ");
//     }
// Console.WriteLine();
// }


void PrintArray(int[,]matr)
{
   for (int i = 0; i < 3; i++ ) // по строкам либо можно использовать для поиска "matrix.GetLength(0)"
   {
    for (int j = 0 ; j < 4; j ++) // внутренний по столбцам либо можно использовать для поиска "matrix.GetLength(1)"
    {
          Console.Write ($"{matr[i, j]} ");
    }
   Console.WriteLine();
   }
}

void FillArray(int[,]matr)// заполняем нашу матрицу случайными цифрами
{
   for (int i = 0; i < 3; i++ ) // по строкам либо можно использовать для поиска "matrix.GetLength(0)"
   {
    for (int j = 0 ; j < 4; j ++) // внутренний по столбцам либо можно использовать для поиска "matrix.GetLength(1)"
    {
        matr[i,j]= new Random().Next (1, 10);//[1, 10]
    }
   
   }
}

int [,] matrix = new int [3,4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();// пробел пустая строка
PrintArray(matrix);

