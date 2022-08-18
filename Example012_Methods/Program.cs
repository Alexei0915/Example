// Вид 1 ничего не возвращают и ничего не принимают

void Method1()
{
    Console.WriteLine("Например автор или еще что то ");
}
Method1(); // вызов метода (обязательно со скобочками)


//Вид 2 ничего не возвращают но могут принимать какие либо аргументы 

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения");

//вид 2.0

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
       Console.WriteLine(msg);
       i++; // Инкримент (увеличение счетчика + 1 ) а уменьшение декремент 
    }
}
Method21(msg:"Текст",count: 4);// Указываем какому аргументу какое значение хотим присвоить. Цифра означает сколько раз хотим увидеть текст 


// Вид 3 методы которые что то возвращают но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 что то принимают и что то возвращают  

// string Method4(int count, string text)
// {
//   int i = 0;
//   string result = String.Empty;

//     while (i < count)
//     {
//       result = result + text;
//       i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{

    string result = String.Empty;
    for(int i = 0; i< count ; i++)
    {
      
      result = result + text;
    
    }
    return result;
}

string res = Method4(10, "S" );
Console.WriteLine(res);
