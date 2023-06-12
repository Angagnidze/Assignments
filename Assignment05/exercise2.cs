//2
int size = 0;
char[] Arr = new char[size];
Arr = FillArray(size, Arr); ;

//foreach (char c in Arr)
//{
//    Console.Write(c + " ");
//}
//Console.WriteLine();
int SecondMethod = CountChar(Arr, 'm');
//Console.WriteLine(SecondMethod);

PrintArray('m', SecondMethod);


char [] FillArray(int size, char[] CharrArray)
{
    Console.WriteLine("sheiyvane zoma: ");
    size = Convert.ToInt32(Console.ReadLine());
    char[] charr = new char[size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("masivis elementi: ");
        char input = Convert.ToChar(Console.ReadLine());
        charr[i] = input;
        
    }
    return charr;
}

int CountChar(char[] charr,char c)
{
    
    int count = 0;
    foreach(char i in charr)
    {
        if(i == c)
            count++;
    }
    return count;
    
}

void PrintArray(char c, int count)
{
    Console.WriteLine($"simbolo {c} shegvxvda " + count + " jer");
  
}
