using System;
using System.Collections.Generic;

class CyberSecurityChatbot
{
    static void Main()
    {
        //ASCII art banner for visual effect
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@@@@@@@@@#..*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@@@@@@@@@@+=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@@@@@@@@#-::-#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@@@@@..........@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@@%+...       ...+%@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@%:..+%%%%%%%%%*...%@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@...#@@@@@@@@@@@@...@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@...#@  @@@@@@  @...@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@...#@  @@@@@@  @...@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@...#@@@@@@@@@@@@...@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@@...#@@@@@@@@@@...@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@@@@..  ...... ..@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@    @ @@@@@ @@@@@ @@@@@          @@@@@@@@@");
        Console.WriteLine("@@@@@@@ @@@@@@ @@@@@ @@@@ @ @@@@@@@@@ @@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@ @@@@@@       @@@ @@@ @@@@@@@@ @@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@ @@@@@@ @@@@@ @@       @@@@@@@ @@@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@     @ @@@@@ @ @@@@@@@ @@@@@@ @@@@@@@@@@@@");
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

        //Displays welcome message
        Console.WriteLine("Welcome to the Cybersecurity Awareness Chatbot!");

        //Asks for and stores the users name
        string name = GetUserInput("What is your name? ");
        Console.WriteLine($"Hello, {name}! I'm here to help you stay safe online.\n");

        //These are predefined responses to specific user questions
        Dictionary<string, string> responses = new Dictionary<string, string>
        {
            { "how are you", "I'm just a bot, but I'm running smoothly! Thanks for asking, {name}." },
            { "what’s your purpose", "I help users learn about cybersecurity and safe online practices." },
            { "what can you do", "I can provide tips on password security, phishing awareness, and general online safety." },
            { "what can I ask you", "You can ask me about cybersecurity topics like passwords, phishing, and online privacy." }
        };

        //Loop to allow continuous interaction until user types "exit"
        while (true)
        {
            //Gets the user input
            string userInput = GetUserInput("Ask me a cybersecurity-related question (or type 'exit' to quit): ").ToLower();

            //Exit condition
            if (userInput == "exit")
            {
                Console.WriteLine($"Goodbye, {name}! Stay safe online.");
                break;
            }

            //Check if chatbot has a predefined response
            if (responses.ContainsKey(userInput))
            {
                //Print response, replacing {name} placeholder with actual user's name
                Console.WriteLine(responses[userInput].Replace("{name}", name));
            }
            else
            {
                //Fallback response for unknown questions
                Console.WriteLine("I'm not sure how to answer that. Try asking something about cybersecurity.");
            }
        }
    }

    //A Method to get user input with validation to prevent empty strings
    static string GetUserInput(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);              //Displays the prompt
            input = Console.ReadLine().Trim(); //Reads and trim input
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be empty. Please try again.");
            }
        } while (string.IsNullOrEmpty(input));

        return input; //Returns the valid user input
    }
}
