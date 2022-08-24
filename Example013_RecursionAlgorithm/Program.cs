// Пример со строками и столбцами 
string[,] table = new string [2,5];
// String.Empty - константа инициализация строк 
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4] - столбики (индекс с 0 )
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4] - меняем индекс строки

table[1,2]="слово";

for (int rows = 0; rows <2; rows++)
{
    for (int colums = 0; colums < 5;colums++)
    {
        Console.WriteLine($"-{table[rows,colums]}-");
    }
}
