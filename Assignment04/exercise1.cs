//1
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

int a = 0;
for (int j = 0; j < NaturalNumber.Length; j++)
{
    for (int n = j + 1; n < NaturalNumber.Length; n++)
    {
        if (NaturalNumber[j] > NaturalNumber[n])
        {
            a = NaturalNumber[n];
            NaturalNumber[n] = NaturalNumber[j];
            NaturalNumber[j] = a;



        }
    }
    Console.Write(NaturalNumber[j] + " ");

}
