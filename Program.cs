using System.Runtime.CompilerServices;

namespace Quiz
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\n\t\t\t\t\t\tWelcome to the Te Reo Quiz!");//The name of the Quiz and the beautiful first welcome message
            Console.Write("\n\n\n\n\n\n\t\t\t\t\t\tPlease enter your name: "); //asks user to Input their name (manners are key)
            string name1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\tHello " + name1 + " ,There are Three Different Difficulties you can choose from \n\n\t\t\t(1)Easy\t\t(2)Intermediate\t\t(3)Impossible\t\t(4)Exit"); //welcomes user and asks them to choose their level depending on how smart they are. 

            int Thelevel;
            while (true)//while statement. asks for input 1-4 and when the user inputs 1 it breaks the loop and sends them to the 
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out Thelevel))
                {
                    if (Thelevel == 1)//if the user inputs "1" it breaks the loop and sends them to the Easy level
                    {
                        EasyMode();
                        break;
                    }
                    else if (Thelevel == 2)//if the user inputs "2" it breaks the loop and sends them to the indermediate Quiz
                    {
                        IntermediateMode();
                        break;
                    }
                    else if (Thelevel == 3)//if the user inputs "3" it breaks the loop and sends them to the Impossible Quiz
                    {
                        ImpossibleMode();
                        break;
                    }
                    else if (Thelevel == 4)//If the user inputs 4 it takes that input and asks if the user wants to exit the program
                    {
                        Console.WriteLine("Do you want to exit? (y/n)");
                        string exitInput = Console.ReadLine();
                        if (exitInput.ToLower() == "y")//if the user inputs a capital "Y" it converts it to a lower and will exit the program. if "N" is entered then it loops back to the start 
                        {
                            Environment.Exit(1);// exit
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

        private static void IntermediateMode()//Start of the intermediate Level 

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

            string[] Interquestions = new string[]//an array that prints the Questions on the screen
                {
                "What is the Maori word for 'Sun'?\nA) Rangi\nB) Marama\nC) Ra",//first question
                "What is the Maori word for 'family'?\nA) Whanau\nB) Kaumatua\nC) Kaitiaki",//second quesion
                " What is the Maori word for \"wind\"? \nA) Hau\nB) Ahi\nC) Kaha",//third quesion
                "What is the Maori word for 'Ccean'? \nA) Moana\nB) Awa\nC) Wai",//fourth question
                "5. What is the Maori word for \"earth\"? \nA) Whenua\nB) Awa\nC) Wai "//last quesion
                };

            int score = 0;

            for (int i = 0; i < Interquestions.Length; i++)//In this loop it checks the score and if the users input is equal to what the answer is it will add a score if not it will print incorrect on the screen.
            {
                Console.WriteLine(Interquestions[i]);
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

        private static void ImpossibleMode()//Impossible Level
        {
            int score = 0;
            Console.WriteLine(".");
            Console.Clear();
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\t\n\t\t\t\t\t\tLoading Impossible Quiz: ");//outputs the Welcome message to Impossible mode
            
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
            Console.WriteLine("Quesion (1)\n How Do you say Hello in Maori\n(a)Sup G\n(b)Kia Ora\n(c)Hiii");//uses A B C style questions to make it a bit easier then asking for the user to type in their answer


            Console.Read();//this stops the nonsense from showing up at the bottom of the screen
        }//end of Impossible quiz

        private static void EasyMode()//Start of easy Level
        {

            //loading bar that looks cool and counts as an array? 2 in 1
            Console.WriteLine(".");
            Console.Clear();
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\t\n\t\t\t\t\t\tLoading The Easy Quiz: ");//Output
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
                string[] Easyquestions = new string[]//uses an array to show the easy questions
                {
                "What does 'kia ora' mean?\nA) Thank you\nB) Hello\nC) Goodbye",//first question
                "What is the Maori word for 'family'?\nA)Kaumatua\nB)Whanau\nC) Kaitiaki",//second question
                "What is a 'haka'?\nA) A traditional dance\nB) A type of food\nC) A musical instrument",//Third Question
                "What is the name of the Maori god of the forest?\nA) Tane\nB) Maui\nC) Rongo",//fourth Question
                "What is the Maori word for 'water'?\nA) Wai\nB) Awa\nC) Moana"//Final question
                };
                var EasyAnswers = new string[]
                {
                    "B,B,A,A,B"
                };
                int score = 0;

                for (int i = 0; i < Easyquestions.Length; i++)
                {
                    Console.WriteLine(Easyquestions[i]);
                    string answer = Console.ReadLine().ToUpper(); //Converts all Input (thats valid) to upper so the program can understand it 

                    if (answer == "A" || answer == "B" || answer == "C")//This if statement waits for the users input and checks if the input is equal to what the actual answer is.
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
                        Console.WriteLine("Invalid answer!");//When the user Fails to input A B or C it tells them its invalid and moves on to the next question (Hopefully they learn their lesson
                    }
                }
                Console.Clear();
                Console.WriteLine("Congrats You Made it to the end\nYour final score is: " + score);
                Console.WriteLine("t");
            }
        }

    }
    //end of easy quiz

}
 



         




      




