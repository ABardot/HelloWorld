﻿using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main()
        {
            //Part one greetings statement
            //string messageOne = "Hello World!";
            //string messageTwo = "I am Spartacus";

            //// Part two set initial Spartacus attributes
            //int ageOne = 35;
            ////int ageTwo = 70;
            //double heightOne = 72.50;
            ////double heightTwo = 91.45;
            //float weightOne = 210.0284606f;
            ////float weightTwo = 331.12345678f;
            //bool isGodLikeOne = true;
            ////bool isGodLikeTwo = false;
            ////char genderMale = 'M';
            ////char genderFemale = 'F';

            //Console.WriteLine("I am {0} years old, and yes it's {1} I am god like.", ageOne, isGodLikeOne);
            //Console.WriteLine("I weigh around {0} pounds , and I am around {1} inches tall", weightOne, heightOne);

            //Console.WriteLine("I am " + ageOne + " years old," + " and I am God like");
            //Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall");

            ////Part three display variable values
            //Console.WriteLine(messageOne);
            //Console.WriteLine(messageTwo);

            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(isGodLikeOne);
            //Console.WriteLine(genderMale);

            ////Part five variable reassignment
            //ageTwo = 110;
            //Console.WriteLine(ageTwo + ageOne);
            //heightTwo = 35.12345f;
            //Console.WriteLine(heightTwo + heightOne);
            //weightTwo = -429.1234573f;
            //Console.WriteLine(weightTwo + weightOne);

            ////Part six math operator examples
            //int ageThree = 80;
            //ageTwo = 70;
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            //// Part seven Increment and decrement operators
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);

            //Console.WriteLine("5" == "5");
            //Console.WriteLine(40 != 40);
            //Console.WriteLine(11 < 4);

            //Part eight concatenation example
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));
            //Console.WriteLine(messageOne + " " + messageTwo + ".");

            //// Part eleven string conditional statement
            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //int city1Distance, city2Distance, city3Distance;

            ////Solicit user input
            //Console.WriteLine("What is the distance to {0}?", city1);
            //city1Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to " + city2 + "?");
            //city2Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //city3Distance = int.Parse(Console.ReadLine());

            //if ((city1Distance <= 125) && ((city1Distance < city2Distance) && (city1Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Vesuvius");
            //}

            //if ((city2Distance <= 125) && ((city2Distance < city1Distance) && (city2Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Nola");
            //}

            //if ((city3Distance <= 125) && ((city3Distance < city1Distance) && (city3Distance < city2Distance)))
            //{
            //    Console.WriteLine("We will march to Nuceria");
            //}

            //Part 10
            //Console.WriteLine("What is your rank?");
            //string rank = Console.ReadLine();

            //Console.WriteLine("What is your age?");
            //int age = int.Parse(Console.ReadLine());

            //if ((rank == "officer") || (age <= 26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you are staying home.");
            //}

            //Part twelve
            //Console.WriteLine("What is your rank solder?");
            //string rank = Console.ReadLine();

            //Console.WriteLine("What is your age soldier?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is your job soldier");
            //string job = Console.ReadLine();

            //if ((rank == "officer") || (age >= 26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}
            //else if ((job == "cook") || (age >= 26))
            //{
            //    Console.WriteLine("My army has to eat. Pack your pots and pans.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry you are staying home.");
            //}

            switch (job)
            {
                case "Infantry":
                    Console.Write("You will carry a sword");
                    break;

                case "archers":
                    Console.Write("You will carry a bow and arrow");
                    break;

                case "supply":
                    Console.Write("You will carry pots and pans");
                    break;

                case "specialist":
                    Console.Write("You will operate catapult");
                    break;

                default:
                    Console.WriteLine("You will ride horseback");
                    break;
            }

            //Lisa is cooking muffins. The recipe calls for 7 cups of sugar.She has already put in 2 cups.How many more cups does she need to put in?
            //At a restaurant, Mike and his three friends decided to divide the bill evenly.If each person paid $13 then what was the total bill ?
            //How many packages of diapers can you buy with $40 if one package costs $8 ?
            //Last Friday Trevon had $29.Over the weekend he received some money for cleaning the attic.He now has $41.How much money did he receive ?
            //Last week Julia ran 30 miles more than Pranav.Julia ran 47 miles.How many miles did Pranav run ?
            //How many boxes of envelopes can you buy with $12 if one box costs $3 ?
            //After paying $5.12 for a salad, Norachai has $27.10.How much money did he have before buying the salad ?
            //int cup = 7 - 2;
            //int bill = 4 * 13;
            //int packageDiapers = 40 / 8;
            //int money = 29 + 41;
            //int ran = 47 - 30;
            //int envelopes = 12 / 3;
            //double salad = 5.12 + 27.10;
            //Console.WriteLine("Lisa needs {0} cups of sugar.\r\nThe total bill was ${1}.\r\nYou can buy {2} packages of diapers.\r\nTrevon received ${3}.\r\nPranav ran {4} more miles than Julia.\r\nYou can buy {5} envelope with $12 \r\nThe total bill was ${6}. ", cup, bill, packageDiapers, money, ran, envelopes, salad);

            ////Lisa is cooking muffins. The recipe calls for 7 cups of sugar. She has already put in 2 cups. How many more cups does she need to put in?
            //int result = 7 - 2;
            //Console.WriteLine("Lisa needs {0} cups of sugar.", result);

            ////At a restaurant, Mike and his three friends decided to divide the bill evenly. If each person paid $13 then what was the total bill?
            //result = 4 * 13;
            //Console.WriteLine("The total bill was ${0}.", result);

            ////How many packages of diapers can you buy with $40 if one package costs $8?
            //result = 40 / 8;
            //Console.WriteLine("You can buy {0} packages of diapers.", result);

            ////Last Friday Trevon had $29. Over the weekend he received some money for cleaning the attic. He now has $41. How much money did he receive?
            //result = 29 + 41;
            //Console.WriteLine("Trevon received ${0}.", result);

            ////Last week Julia ran 30 miles more than Pranav. Julia ran 47 miles. How many miles did Pranav run?
            //result = 47 - 30;
            //Console.WriteLine("Pranav ran {0} more miles than Julia.", result);

            ////How many boxes of envelopes can you buy with $12 if one box costs $3?
            //result = 12 / 3;
            //Console.WriteLine("You can buy {0} envelope boxes with $12.", result);

            ////After paying $5.12 for a salad, Norachai has $27.10.How much money did he have before buying the salad?
            //double salad = 5.12 + 27.10;
            //Console.WriteLine("The total bill was ${0}.", salad);

            //double salad = 5.12;
            //double moneyBefore = 27.10;
            //double result = salad + moneyBefore;
            //Console.WriteLine("The total bill was ${0}.", result);

            //string myGreeting = "Hello";
            //Console.WriteLine(myGreeting.ToUpper()); // prints "HELLO"
            //Console.WriteLine(myGreeting.ToLower()); // prints "hello"
            //Console.WriteLine(myGreeting); // prints "Hello"

            //Console.WriteLine("Enter a color, please.");
            //string response = Console.ReadLine();

            //if (response.ToLower().Equals("red"))
            //{
            //    Console.WriteLine("Roses can be red. Also, lilies.");
            //}

            //Part ten string length examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwoLength);
        }
    }
}