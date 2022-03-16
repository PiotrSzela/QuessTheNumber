using System;

namespace QuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
        begin:
            Console.ResetColor();
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            
            Console.WriteLine("Quess the number from 1 to 100\nTry to do it in 5 steps or less");

            int howMuch = 0;
            int myNumber;

            do
            {

                howMuch++;
                Console.Write("Give me the number:");
                myNumber = int.Parse(Console.ReadLine());
                if (myNumber < 1 || myNumber > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Your number is incorrect! Choose between 1 to 100\n Try again!");
                    Console.ResetColor();
                }
                else
                {
                    if (myNumber > randomNumber)
                    {
                        Console.WriteLine("The number is too high!");
                    }
                    else if (myNumber < randomNumber)
                    {
                        Console.WriteLine("The number is too low!");
                    }
                    else
                    {
                        if (howMuch <= 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($" Correct number!!!!\n You need {howMuch} steps to win!!\n PERFECT!!");

                        }
                        else if (howMuch <= 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($" Correct number!\n You need {howMuch} steps to win!\n GOOD!");

                        }

                        else 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($" Correct number\n But you need {howMuch} steps to win :( its to much :(\n Try again !");

                        }
                    }
                }
            } while (myNumber != randomNumber);
            Console.Write(" Play again?\n Press y/n ");
            playOrNot:
            string yesOrNo = Console.ReadLine();
            switch(yesOrNo)
            {
                case ("y"):
                    goto begin;
                case ("n"):
                    break;
                default:
                    Console.Write("Press y/n");
                    goto playOrNot;

            }
        
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
