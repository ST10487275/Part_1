using System;
using System.IO;
using System.Media;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";

            //Voice greeting
            PlayVoiceGreeting();

            //ASCII
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"
==================================================
        CYBERSECURITY AWARENESS BOT
      Your First Line of Digital Defence
==================================================
");

            Console.ResetColor();

            Console.WriteLine(new string('-', 50));

            //Chatbot interaction
            Chatbot bot = new Chatbot();
            await bot.StartConversation();
        }

        static void PlayVoiceGreeting()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");

            Console.WriteLine("Audio path: " + path); //helps debug file location

            if (File.Exists(path))
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(path);
                    player.Load();      //ensures file is loaded properly
                    player.PlaySync();  //plays audio and waits until finished
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[Voice greeting could not play]");
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("[greeting.wav not found]");
            }
        }
    }
}