namespace Maori_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1;
            int input;
            Console.WriteLine("\t\t\t\t\tWelcome To the Te Reo Quiz!!\n\n\n\n"); //the title which is displayed at the top middle of the screen then new line for the name input.
            Console.Write("Please enter Name: ");
            name1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\t\t\tHello " + name1 + " ,There are Three Different Difficulties you can choose from \n\n\t\t\t(1)Easy\t\t(2)Intermediate\t\t(3)Impossible\t\t(4)Exit");
            input = Console.ReadLine(); 
            Console.Clear();
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
                Console.WriteLine("GoodBye, Play again soon!");
            }







            Console.Read();
        }
        static void EasyMode() {

            Console.WriteLine("Welcome to Easy Mode. GoodLuck!!");

        }
        static void IndermediateMode()
        {
            Console.WriteLine("Welcome to Intermediate Mode. Have Fun!");
        }
        static void Impossible()
        {
            Console.WriteLine("Welcome to The Impossible Quiz, Best Of Luck!");
        }
       
    }
}