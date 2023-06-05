using System;

namespace Assignment;

public class Program
{
    public static void Main(string[] args)
    {
        //1
        //Console.WriteLine("Enter temperature in Celsius:");
        //string UserInput = Console.ReadLine();
        //int Input = Convert.ToInt32(UserInput);

        //if (Input < 0)
        //{
        //    Console.WriteLine("Yinavs");
        //}
        //else if (Input > 0 && Input < 30)
        //{
        //    Console.WriteLine("Kargi Amindia");
        //}
        //else if (Input > 30)
        //{
        //    Console.WriteLine("Cxela");
        //}

        //2
        //Console.WriteLine("enter your birth year: ");
        //string userinput = Console.ReadLine();
        //int intinput = Convert.ToInt32(userinput);
        //int year = intinput % 12;

        //switch (year)
        //{
        //    case 0:
        //        {
        //            Console.WriteLine("you are born in monkey year");
        //            break;
        //        }
        //    case 1:
        //        {
        //            Console.WriteLine("you are born in rooster year");
        //            break;
        //        }
        //    case 2:
        //        {
        //            Console.WriteLine("you are born in dog year");
        //            break;
        //        }
        //    case 3:
        //        {
        //            Console.WriteLine("you are born in pig year");
        //            break;
        //        }
        //    case 4:
        //        {
        //            Console.WriteLine("you are born in rat year");
        //            break;
        //        }
        //    case 5:
        //        {
        //            Console.WriteLine("you are born in ox year");
        //            break;
        //        }
        //    case 6:
        //        {
        //            Console.WriteLine("you are in tiger year");
        //            break;
        //        }
        //    case 7:
        //        {
        //            Console.WriteLine("you are born in rabbit year");
        //            break;
        //        }
        //    case 8:
        //        {
        //            Console.WriteLine("you are born in  dragon year");
        //            break;

        //        }
        //    case 9:
        //        {
        //            Console.WriteLine("you are born in snake year");
        //            break;
        //        }
        //    case 10:
        //        {
        //            Console.WriteLine("you are born in horse year");
        //            break;
        //        }
        //    case 11:
        //        {
        //            Console.WriteLine("you are born in sheep year");
        //            break;
        //        }
        //    default:
        //        {
        //            Console.WriteLine("invalid input");
        //            break;
        //        }

        //}

        ////3
        Console.WriteLine("enter rock, paper or scissors: ");
        string userinput = Console.ReadLine();
        var rnd = new Random();
        int randomnum = rnd.Next(1, 4);
        int computernum = 0;
        if (userinput == "rock")
        {
            computernum = 1;
        }
        else if (userinput == "paper")
        {
            computernum = 2;
        }
        else if (userinput == "scissors")
        {
            computernum = 3;
        }
        switch (randomnum)
        {
            case 1:
                {

                    Console.WriteLine("1.rock, 2.paper, 3.scissors, computer choose: " + randomnum);
                    if (computernum == 1)
                    {
                        Console.WriteLine("draw");
                    }
                    else if (computernum == 2)
                    {
                        Console.WriteLine("you won");
                    }
                    else if (computernum == 3)
                    {
                        Console.WriteLine("you lost");
                    }
                    break;
                }


            case 2:
                {
                    Console.WriteLine("1.rock, 2.paper, 3.scissors, computer choose: " + randomnum);
                    if (computernum == 1)
                    {
                        Console.WriteLine("you lost");
                    }
                    else if (computernum == 2)
                    {
                        Console.WriteLine("draw");
                    }
                    else if (computernum == 3)
                    {
                        Console.WriteLine("you won");
                    }
                    break;
                }


            case 3:
                {
                    Console.WriteLine("1.rock, 2.paper, 3.scissors, computer choose: " + randomnum);
                    if (computernum == 1)
                    {
                        Console.WriteLine("you won");
                    }
                    else if (computernum == 2)
                    {
                        Console.WriteLine("you lost");
                    }
                    else if (computernum == 3)
                    {
                        Console.WriteLine("draw");
                    }
                    break;

                }

        }

    }

    }



        