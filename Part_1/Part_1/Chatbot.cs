using System;
using System.Threading.Tasks;

namespace Part_1
{
    public class Chatbot
    {
        private string userName;

        public async Task StartConversation()
        {
            //Ask user for name
            Console.Write("What is your name? ");
            userName = Console.ReadLine();

            //Validate name
            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Please enter a valid name: ");
                userName = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nNice to meet you, {userName}! I'm here to help you stay safe online.");
            Console.ResetColor();

            Console.WriteLine(new string('-', 50));

            //Loop
            while (true)
            {
                Console.Write($"{userName}, ask me something (type 'exit' to quit): ");
                string input = Console.ReadLine().ToLower();

                //No input
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please type something.");
                    continue;
                }

                //Exit
                if (input == "exit")
                {
                    Console.WriteLine("Goodbye! Stay safe online 🔒");
                    break;
                }

                //Response
                string response = ResponseLogic.GetResponse(input);
                await TypeText(response);

                Console.WriteLine(new string('-', 50));
            }
        }

        //Typing effect
        private async Task TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                await Task.Delay(20);
            }
            Console.WriteLine();
        }
    }
}