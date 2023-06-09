//2

int n;
Console.WriteLine("sheiyavne pirveli masivis raodenoba: ");
n = Convert.ToInt32(Console.ReadLine());
string[] firstarray = new string[n];


int i, j;
for (i = 0; i < n; i++)
{
    Console.WriteLine("sheiyvane pirveli masivis elementebi: ");
    var input = Console.ReadLine();
    firstarray[i] = input;
}
Console.WriteLine("sheiyavne meore masivis raodenoba: ");
var m = Convert.ToInt32(Console.ReadLine());
int[] secondarray = new int[m];
for (j = 0; j < m; j++)
{
    Console.WriteLine("sheiyvane meore masivis elementebi: ");
    var input2 = Convert.ToInt32(Console.ReadLine());
    secondarray[j] = input2;

}

string[] masivi3 = new string[m];

Console.Write("Result: ");
for (i = 0; i < n; i++)
{
    masivi3[i] = firstarray[i] + " " + secondarray[i];

    
    Console.Write(masivi3[i] + " ");


}
