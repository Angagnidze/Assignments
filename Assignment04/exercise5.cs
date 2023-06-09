//5

int[,] firstarr = new int[2, 2];
int[,] secarr = new int[3, 3];

int FirstArrayFirstDimension = firstarr.GetLength(0);
int FirstArraySecondDimension = firstarr.GetLength(1);
for (int i = 0; i < FirstArrayFirstDimension; i++)
{
    for (int j = 0; j < FirstArraySecondDimension; j++)
    {
        Console.WriteLine("sheiyvane matricis mnishvneloba: ");
        var inp = Convert.ToInt32(Console.ReadLine());
        firstarr[i, j] = inp;
    }
}
for (int i = 0; i < FirstArrayFirstDimension; i++)
{
    for (int j = 0; j < FirstArrayFirstDimension; j++)
    {
        Console.WriteLine($"[{i},{j}]: " + firstarr[i, j] + " ");

    }
    Console.WriteLine();
}

int SecondArrayFirstDimension = secarr.GetLength(0);
int SecondArraySecondDimension = secarr.GetLength(1);
for (int i = 0; i < SecondArrayFirstDimension; i++)
{
    for (int j = 0; j < SecondArraySecondDimension; j++)
    {
        Console.WriteLine("sheiyvane matricis mnishvneloba: ");
        var inp = Convert.ToInt32(Console.ReadLine());
        secarr[i, j] = inp;
    }
}
for (int i = 0; i < secarr.GetLength(0); i++)
{
    for (int j = 0; j < secarr.GetLength(1); j++)
    {
        Console.WriteLine($"[{i},{j}]: " + secarr[i, j] + " ");

    }
    Console.WriteLine();
}
int det = 0;
Console.WriteLine("choose matrix 1.2x2 or 2.3x3");
int userInput = Convert.ToInt32(Console.ReadLine());

if (userInput == 1)
{
    det = (firstarr[0, 0] * firstarr[1, 1]) - (firstarr[0, 1] * firstarr[1, 0]);
    if (det < 0)
    {
        det *= -1;
    }
    Console.WriteLine(det);
}
else if (userInput == 2)
{
    det = secarr[0, 0] * ((secarr[1, 1] * secarr[2, 2] - (secarr[1, 2] * secarr[2, 1])) -
        secarr[0, 1] * ((secarr[1, 0] * secarr[2, 2]) - (secarr[1, 2] * secarr[2, 0])) +
        secarr[0, 2] * ((secarr[1, 0] * secarr[2, 1]) - (secarr[1, 1] * secarr[2, 0])));
    if (det < 0)
    {
        det *= -1;

    }
    Console.WriteLine(det);

}
