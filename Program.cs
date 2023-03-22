using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Maori_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1, answer1;
            int input, mode;
            int score = 0;
            bool isRight = true;

            Console.WriteLine("\t\t\t\t\tWelcome To the Te Reo Quiz!!\n\n\n\n"); //the title which is displayed at the top middle of the screen then new line for the name input.
            Console.Write("Please enter Name: ");
            name1 = Console.ReadLine();
            while (isRight)
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\t\t\tHello " + name1 + " ,There are Three Different Difficulties you can choose from \n\n\t\t\t(1)Easy\t\t(2)Intermediate\t\t(3)Impossible\t\t(4)Exit");
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Please enter a valid number");
                }
                else
                {
                    break;
                }

                if (input == 1)
                {
                    EasyMode();
                }
                else if (input == 2)
                {
                    IndermediateMode();
                }
                else if (input == 3)
                {
                    Impossible();
                }
                else if (input == 4)
                {
                    Console.WriteLine("Are you sure you want to exit? (Y/N)");
                    string exitAnswer = Console.ReadLine();
                    if (exitAnswer.ToLower() == "y")
                    {
                        ExitMode();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }

            static void EasyMode()
            {
                //added 3 different levels and a greeting when one is selected
                System.Console.WriteLine("\n\n\t\t\t\t\tWelcome to Easy Mode. GoodLuck!!!");
                string answer2;
                int score = 0;
                if (int.TryParse(Console.ReadLine(), out score))
                    // Question 1
                    Console.WriteLine("What is The Maori name for New Zealand");
                Console.WriteLine("A) White cloud");
                Console.WriteLine("B) Aotearoa");
                Console.WriteLine("C) New Zealand");
                answer2 = Console.ReadLine().ToUpper();
                if (answer2 == "B")
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
                if (answer2 == "C")
                {
                    Console.WriteLine("What does Whero mean?");
                    Console.WriteLine("A) Blue");
                    Console.WriteLine("B) Green");
                    Console.WriteLine("C) Red");
                    answer2 = Console.ReadLine();
                }
                // Question 2
                
                if (answer2 == "C")
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }

                // Question 3
                Console.WriteLine("How Do you say hello in Maori?");
                Console.WriteLine("A) Sup G");
                Console.WriteLine("B) Kia Ora");
                Console.WriteLine("C) Morena");
                answer2 = Console.ToUpper();
                if (answer2 == "B")
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }

                // Final score
                Console.WriteLine("Your final score is: " + score);

            }

            static void IndermediateMode()
            {
                System.Console.WriteLine("\n\n\t\t\t\t\tWelcome to Intermediate Mode. Have Fun!");
                int score = 0;
                string[] questions =
                {
                    System.Console.WriteLine("Test");
                }


            static void Impossible()
                {
                    System.Console.WriteLine("\n\n\t\t\t\tWelcome to The Impossible Quiz, Best Of Luck!");
                }

                static void ExitMode()
                {
                    System.Console.WriteLine("Thank you for playing!");
                }
            }
        }
    }
}
    
    

