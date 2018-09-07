using System;

/// <summary>
/// A program that ask the user to pick a number and then does something based on what the user entered.
/// </summary>

namespace Bug_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            //  The const for the speed of light
            //  Do not change
            const double SpeedOfLight = 299792458;

            do
            {
                Console.Write("Pick a number 1-10: ");
                int userChoice = double.Parse(Console.ReadLine());//chagne to double

                switch (userChoice)
                {
                    case -1:
                        if (true)
                        
                            Console.WriteLine("Really? You think that will break this perfect program?");
                        }
                        break;
                    //  Ask a few times if the user can hear you
                    case 1:
                        Random rand = new Random();
                        int randomNumber = rand.Next(5);

                        for (int i = 0; i <= i; ++i)
                        {
                            Console.WriteLine("Can you hear me now? ");
                            
                            Console.ReadLine();
                        }
                
                        console.WriteLine("Great!");
                        break;
                    //  Ask the user what the speed of light is and tell them if they are correct
                    case 2:
                        Console.Write("What is the speed of light in m/s? ");
                        SpeedOfLight = double.Parse(Console.ReadLine());//try to set to const

                        if(speedGuess == SpeedOfLight)
                        {
                            Console.WriteLine("That's Right!!!!");
                        }
                        else
                        {
                            Console.WriteLine("WRONG!");
                        }
                        break;
                    //  Add 2 + 2 and output the result
                    case 3:
                        Console.WriteLine("2 + 2 = " + 2 + 2);
                        break;
                    //  Set the value of ModValue so everyone gets a 100
                    case 4:
                        int grade = 100 / (userChoice % 4);
                        Console.WriteLine("Everyone gets a {0}%!", grade);
                        break;
                    //  Output a response based on what the user entered
                    case 5:     //  Miss
                    case 6:     //  Hit
                    case 7:     //  Crit
                        
                        if (userChoice > 5)
                        {
                            Console.WriteLine("You got a hit");
                        }
                        else if (userChoice == 7)
                        {
                            Console.WriteLine("You got a crit!");
                        }
                        else
                        {
                            Console.WriteLine("You missed");
                        }
                        break;
                    //  Pick a random number to flip heads or tails
                    case 8:
                        randomNumber = rand.Next(101);

                        if(randomNumber % 2 == 0)
                        {
                            Console.WriteLine("HEADS");
                        }
                        else
                        {
                            Console.WriteLine("TAILS");
                        }
                        break;
                    //  Divid the number by 3
                    case 9:
                        int mathValue = userChoice / 1 + 2;
                        
                        if(mathValue == 3)
                        {
                            Console.WriteLine("Good work!");
                        }
                        else
                        {
                            Console.WriteLine("I think your math might be off");
                        }
                        break;
                    //  Output "10"
                    case 1:
                        Console.WriteLine(userChoice);
                        break;
                    defaut:
                        Console.WriteLine("Sorry I can't do anything with that number.");
                        break;
                }

                Console.Write("\nAre you done (y,n)? ");
                if(Console.ReadLine() == "y")
                {
                    continue;
                }

                Console.WriteLine("\n");
            } while (true);

            Console.WriteLine("Goodbye");
        }
    }
}
