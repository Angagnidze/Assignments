
//1
int number, counter = 0;
Console.WriteLine("sheiyvanet ricxvi: ");
number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if (number % i == 0)
    {
        counter++;
    }
}
if (counter == 2)
{
    Console.WriteLine("ricxvi martivia");
}
else
{
    Console.WriteLine("ricxvi shedgenilia");
}

//2

int number, counter = 0;

Console.WriteLine("sheiyvanet ricvxi: ");
number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if (number % i == 0)
    {
        Console.WriteLine("ricxvis gamyopia: {0}", i);
        counter++;
    }
}

Console.WriteLine("ricxvis gamyopebis raodenoba aris: " + counter);

//3
int n, sum = 0;
double average = 0.0;
Console.WriteLine("sheuyvanet ricxvebis raodenoba: ");
n = Convert.ToInt32(Console.ReadLine());
int raodenoba = n;
while (n != 0)
{
    Console.WriteLine("sheiyvane ricxvi: ");
    int number = Convert.ToInt32(Console.ReadLine());
    n--;
    if (number > 0)
    {
        sum += number;
    }
    average = (sum) / (raodenoba + 0.0);
}
Console.WriteLine("ricvxebis aritmetikuli sashualo aris: " + average);
Console.WriteLine("ricxvebis jami aris: " + sum);


//5
bool x = true;
while (x)
{
    int min, max, counter = 1;
    Console.WriteLine("enter min number: ");
    min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter max number: ");
    max = Convert.ToInt32(Console.ReadLine());

    var rnd = new Random();
    int rndnumber = rnd.Next(min, max);
    int number;
    bool y = true;

    while (y)
    {

        Console.WriteLine("enter number:");
        number = Convert.ToInt32(Console.ReadLine());
        if (rndnumber != number)
        {
            counter++;
        }
        if (rndnumber == number)
        {
            y = false;
            Console.WriteLine("gamoicani " + counter + " cdashi");
            Console.WriteLine("programis chapiqrebuli ricxvia: " + rndnumber);
        }



    }
    Console.WriteLine("kidev gsurs gagrdzeleba: yes or no ");
    string n = Console.ReadLine();
    if (n == "yes")
    {
        x = true;
    }
    else x = false;
}



