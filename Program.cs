using System;

namespace InClassDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intergalactic Tinder:");
            Console.WriteLine(" ");
            Console.WriteLine("You are an alien scientist visiting earth to experience a date.");
            Console.WriteLine(" ");
            Console.WriteLine("You see a strong brown-eyed human with short hair, and a lovely green eyed human with long red hair.");
            Console.WriteLine(" ");
            Console.WriteLine("Which do you choose to approach? Type Brown or Green:");
            Console.WriteLine(" ");

            string response = Console.ReadLine();

            if (response == "Brown")
            {
                Console.WriteLine("This human makes you feel funny inside. They invite you on a delightful seafood dinner, and then to watch a football game.");
                Console.WriteLine(" ");
                Console.WriteLine("The stadium erupts in chaos as zombies invade the stands and you regret coming to earth as zombies eat your brains.");
                Console.WriteLine(" ");

            }
            else if (response == "Green")
            {
                Console.WriteLine("This human makes you all swooney. They take you to a corny romantic movie, and then you fly to exotic Disney World.");
                Console.WriteLine(" ");
                Console.WriteLine("As you're exiting the Peter Pan ride, you hear a screaming crowd, as zombies swarm Fantasyland and eat your brains.");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("You came here for a date. You really need to choose Brown or Green");
            }
        }
    }
}
