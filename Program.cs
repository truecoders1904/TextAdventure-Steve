using System;

namespace SteveAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction 
            Console.WriteLine("Welcome to INTERGALACTIC TINDER!!!:");
            Console.WriteLine("You are an alien scientist visiting earth to experience a date.");
            Console.WriteLine("You see a strong brown-eyed human with short hair, and a lovely green eyed human with long red hair.");
            Console.WriteLine("Which do you choose to approach? Type Brown or Green:");

            string response = Console.ReadLine();

            if (response == "Brown")
            {// BROWN EYES --> HUNGRY (seafood) or FUN (football)
                Console.WriteLine("This human makes you feel funny inside. They invite you on a date, asking if you are Hungry, or wish to view Fun human entertainment.");
                Console.WriteLine("Type \"Hungry\" or \"Fun\":");

                string responseB = Console.ReadLine();

                if (response == "Hungry")
                {
                    Console.WriteLine("The human takes you on a delightful seafood dinner, where you consume crabs, mussels, shrimp, fish, and many more creatures from deep in the planet's salty, murky, liquid layer.");
                    Console.WriteLine(" ");
                    Console.WriteLine("As you leave the restaurant, burping the taste of musty oysters, you hear screams of \"BRAINS!!!\" as a horde of un-dead humans descends on you.");
                }
                else if (response == "Fun")
                {
                    Console.WriteLine("The human takes you to a football game, where many large humans collide, and they rarely use their foot in conjunction with the ball.");
                    Console.WriteLine(" ");
                    Console.WriteLine("As you return to your seat from the stand which provides fermented seed juice and convoluted salty bread dough, you hear a screaming panicked crowd, as zombies eat your brains while chanting \"SEC! SEC! SEC!\'.");
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("You came here for a date. You really need to choose \"Hungry\" or \"Fun\"");
                }
            }
            else if (response == "Green")
            {// GREEN --> LAZY (romantic movie) or ACTIVE (Disney World)
                Console.WriteLine("This human makes you all swooney. They invite you to enjoy either Lazy or Active human leisure activities.");
                Console.WriteLine("Type \"Lazy\" or \"Active\":");

                string responseG = Console.ReadLine();

                if (response == "Lazy")
                {
                    Console.WriteLine("The human introduces you to \"Netflix and chill\". You spend the next earth rotation watching corny commedies and sappy romantic movies.");
                    Console.WriteLine(" ");
                    Console.WriteLine("When your location again points towards the closest star, you emerge to take the \"walk of shame\" back to your space ship.");
                    Console.WriteLine("As the morning human commute begins, the raucous sound of shambling hominid corpses staggers toward you as they grasp for your brains.");
                }
                else if (response == "Fun")
                {
                    Console.WriteLine("Your human dons a head covering which mimicks the appearance of rodent ears and flies you to Disney World.");
                    Console.WriteLine(" ");
                    Console.WriteLine("After you spend 16 earth hours experiencing the mechanical plastic simulations of fantasy scenarios, a crowd of zombies runs toward you.");
                    Console.WriteLine(" ");
                    Console.WriteLine("You are saved, as the zombie horde is repelled by the sweet, toasty, sugary smell of the dozens of \"churros\" you ate throughout the day.");
                }
                else
                {
                    Console.WriteLine("You came here for a date. You really need to choose \"Lazy\" or \"Active\"");
                }
            }
            else
            {
                Console.WriteLine("You came here for a date. You really need to choose Brown or Green");
            }
            
        }
    }
}
