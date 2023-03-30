using System.Runtime.CompilerServices;

namespace Quiz
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\n\t\t\t\t\t\tWelcome to the Te Reo Quiz!");//The name of the Quiz and the beautiful first welcome message
            Console.WriteLine("\n\nPlease enter your name: "); //asks user to Input their name (manners are key)
            string name1 = Console.ReadLine();
            Console.WriteLine("\n\n\n\n\n\n\n\t\t\tHello " + name1 + " ,There are Three Different Difficulties you can choose from \n\n\t\t\t(1)Easy\t\t(2)Intermediate\t\t(3)Impossible\t\t(4)Exit"); //welcomes user and asks them to choose their level depending on how smart they are. 

            int Thelevel;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out Thelevel))
                {
                    if (Thelevel == 1)
                    {
                        EasyMode();
                        break;
                    }
                    else if (Thelevel == 2)
                    {
                        IntermediateMode();
                        break;
                    }
                    else if (Thelevel == 3)
                    {
                        ImpossibleMode();
                        break;
                    }
                    else if (Thelevel == 4)
                    {
                        Console.WriteLine("Do you want to exit? (y/n)");
                        string exitInput = Console.ReadLine();
                        if (exitInput.ToLower() == "y")
                        {
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Whatever your doing isnt right. Please enter  1, 2, 3, or 4.\n\n\nTry Again!");//if the user fails to input 1-4 it tells them nicely that its wrong and they need to try again
                    }
                }
                else
                {
                    Console.WriteLine("Seriously " + name1 + ". Please just Enter 1, 2, 3, or 4.\n\n\nNot that hard\n Try again :)");
                    //if they still dont understand the code comes to life a bit and asks them to stop joking around and input a number between 1 and 4
                }
            }
        }//end of main method

        private static void IntermediateMode()

        {
            Console.WriteLine(".");
            Console.Clear();
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\tLoading The Intermediate Quiz: ");
            string[] spinner = new string[] { "/", "-", "\\", "|" };
            for (int i = 0; i <= 50; i++)
            {
                Console.Write(spinner[i % spinner.Length]);
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            Console.WriteLine("sending you to Indermediate mode");
            Console.Clear();

            string[] questions = new string[]
                {
                "What is the Maori word for 'Sun'?\nA) Rangi\nB) Marama\nC) Ra",//first question
                "What is the Maori word for 'family'?\nA) Whanau\nB) Kaumatua\nC) Kaitiaki",//second quesion
                " What is the Maori word for \"wind\"? \nA) Hau\nB) Ahi\nC) Kaha",//third quesion
                "What is the Maori word for 'Ccean'? \nA) Moana\nB) Awa\nC) Wai",//fourth question
                "5. What is the Maori word for \"earth\"? \nA) Whenua\nB) Awa\nC) Wai "//last quesion
                };

            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                string answer = Console.ReadLine().ToUpper();

                if (answer == "A" || answer == "B" || answer == "C")
                {
                    if (answer == "A")
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong answer!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid answer!");
                }
            }

            Console.WriteLine("Your Final score is: " + score);

        }//end of intermediate mode

        private static void ImpossibleMode()
        {
            int score = 0;
            Console.WriteLine(".");
            Console.Clear();
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\t\n\t\t\t\t\t\tLoading Impossible Quiz: ");
            string[] spinner = new string[] { "/", "-", "\\", "|" };
            for (int i = 0; i <= 50; i++)
            {
                Console.Write(spinner[i % spinner.Length]);
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            Console.WriteLine("sending you: ");
            Console.Clear();
            Console.WriteLine("\n\n\t\t\t\t\t\tWelcome to Impossible Mode\n\n\t\t\t\tThere are Five Questions in this mode! Goodluck");
            Console.WriteLine("Quesion (1)\n How Do you say Hello in Maori\n(a)Sup G\n(b)Kia Ora\n(c)Hiii");


            Console.Read();
        }//end of Impossible quiz

        private static void EasyMode()
        {

            //loading bar that looks cool and counts as an array? 2 in 1
            Console.Write("Loading The Easy Quiz: ");
            string[] spinner = new string[] { "/", "-", "\\", "|" };
            for (int i = 0; i <= 50; i++)
            {
                Console.Write(spinner[i % spinner.Length]);
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            Console.WriteLine("sending you to easy mode");
            Console.Clear();
            Console.WriteLine("\n\t\t\t\t\tWelcome to Easy Mode!!\nThere are Five Questions, GoodLuck");
            {
                string[] Easyquestions = new string[]
                {
                "What does 'kia ora' mean?\nA) Thank you\nB) Hello\nC) Goodbye",
                "What is the Maori word for 'family'?\nA) Whanau\nB) Kaumatua\nC) Kaitiaki",
                "What is a 'haka'?\nA) A traditional dance\nB) A type of food\nC) A musical instrument",
                "What is the name of the Maori god of the forest?\nA) Tane\nB) Maui\nC) Rongo",
                "What is the Maori word for 'water'?\nA) Wai\nB) Awa\nC) Moana"
                };

                int score = 0;

                for (int i = 0; i < Easyquestions.Length; i++)
                {
                    Console.WriteLine(Easyquestions[i]);
                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "A" || answer == "B" || answer == "C")
                    {
                        if (answer == "B")
                        {
                            Console.WriteLine("Correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer!");
                    }
                }

                Console.WriteLine("Your Final score is: " + score);
            }
        }

    }
    //end of easy quiz

}
 



         




      




