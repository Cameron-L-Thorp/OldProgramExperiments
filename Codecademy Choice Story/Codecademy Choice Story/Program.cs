
using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.WriteLine("I was here");
            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine();
            string noise = noiseChoice.ToUpper();

            if (noise == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("THE END.");
            }
            else if (noise == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
                Console.WriteLine("You walk towards it. Do you open it or knock?");
            }
            else 
        {
                Console.WriteLine("Please restart the program and follow the prompts.");
            }
            Console.WriteLine("Type OPEN or KNOCK: ");
            string doorChoice = Console.ReadLine();
            string door = doorChoice.ToUpper();

            if (door == "KNOCK")
            {
                Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
                Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                Console.WriteLine("Type your answer: ");
                string riddleAnswer = Console.ReadLine();
                string riddle = riddleAnswer.ToUpper();

                if (riddle == "NOTHING")
                {
                    Console.WriteLine("The door opens and NOTHING is there.");
                    Console.WriteLine("You turn off the light and run back to your room and lock the door.");
                    Console.WriteLine("THE END.");
                }

                else 
              {
                    Console.WriteLine("You answered incorrectly. The door doesn't open.");
                    Console.WriteLine("THE END.");
                }
            }

            else if (door == "OPEN")
            {
                Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                Console.WriteLine("Enter which key you try(1-3): ");
                string keyChoice = Console.ReadLine();

                switch (keyChoice)
                {
                    case "1":
                        Console.WriteLine("You choose the first key. Lucky Choice!");
                        Console.WriteLine("You unlock and open the door, NOTHING is there. Strange...");
                        Console.WriteLine("THE END.");
                        break;
                        Console.WriteLine("THE END.");
                    case "2":
                        Console.WriteLine("You choose the second key. The door is still locked.");
                        Console.WriteLine("THE END.");
                        break;
                    case "3":
                        Console.WriteLine("You choose the third key. The door is sitll locked.");
                        Console.WriteLine("THE END.");
                        break;
                    default:
                        Console.WriteLine("Whatever is behind that door probably isn't that interesting anyways, you go back to your room.");
                        Console.WriteLine("THE END.");
                        break;
                }

            }
            else 
        {
                Console.WriteLine("Please restart the program and follow the prompts.");
            }
        }
    }
}
