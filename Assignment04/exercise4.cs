//4
int N;
Console.WriteLine("sheiyvane masivis sigrdze: ");
N = Convert.ToInt32(Console.ReadLine());
int[] NaturalNumber = new int[N];

for (int i = 0; i < N; i++)
{
    Console.WriteLine("sheiyvane masivis elementi: ");
    var input = Console.ReadLine();
    NaturalNumber[i] = Convert.ToInt32(input);
}

int maxLength = 1;
int currentLength = 1;
int endIndex = 0;

for (int i = 1; i < NaturalNumber.Length; i++)
{
    if (NaturalNumber[i] > NaturalNumber[i - 1])
    {
        currentLength++;

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            endIndex = i;
        }
    }
    else
    {
        currentLength = 1;
    }
}


for (int i = endIndex - maxLength + 1; i <= endIndex; i++)
{
    Console.Write(NaturalNumber[i] + " ");
}
