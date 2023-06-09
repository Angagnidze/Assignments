//3
using System.ComponentModel.DataAnnotations;

int N;
Console.WriteLine("sheiyvane pirveli masivis raodenoba: ");
N = Convert.ToInt32(Console.ReadLine());
int[] firstarr = new int[N];

for (int i = 0; i < N; i++)
{
    Console.WriteLine("sheiyavne ricxvi: ");
    var inp = Convert.ToInt32(Console.ReadLine());
    firstarr[i] = inp;

}
int M;
Console.WriteLine("sheiyvane meore masivis raodenoba: ");
M = Convert.ToInt32(Console.ReadLine());
int[] Secondarr = new int[M];

for (int i = 0; i < M; i++)
{
    Console.WriteLine("sheiyavne ricxvi: ");
    var inp = Convert.ToInt32(Console.ReadLine());
    Secondarr[i] = inp;

}
int[] thirdarr = new int[N + M];
for (int i = 0; i < N; i++)
{
    thirdarr[i] = firstarr[i];

}
for (int i = 0; i < M; i++)
{
    thirdarr[N + i] = Secondarr[i];

}
for (int i = 0; i < N + M; i++)
{
    Array.Sort(thirdarr);
    Console.Write(thirdarr[i] + " ");


}
