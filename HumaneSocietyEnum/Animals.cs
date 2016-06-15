using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyEnum
{
    
        class Animals
        {
            enum animal { Dogs, Birds, Cats, Rabbits };
            enum age { one, two, three, four, five, six };
            enum dogbreed { Dachshund, Havanese, Pomeranian, Pug, NorfolkTerrier, Maltese, CavalierKingCharlesSpaniel };
            enum birdbreed {Parakeet, Cockatoo, Macaw, Budgerigar, Lovebird }
            enum catbreed { Persian, Siamese, Birman, Ragdoll, Bombay, RussianBlue }
            enum rabbitbreed { Dutch, Beveren, AmericanFuzzyLop, Palomino, Rex}
            
            Random random = new Random();

            public void view()
            {
                string[] animals = Enum.GetNames(typeof(animal));
            
            Console.WriteLine("     The Humane Society Welcomes You      \n");          
            Console.WriteLine("Which animal would you like to see today?\nPlease type your choice:\n     Dogs\n     Cats\n     Rabbits\n     Birds");
            string choice;
            choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "dogs":
                    Console.Clear();
                    
                    Console.WriteLine("You chose to see our Dogs");
                    Dog();
                    break;
                case "cats":
                    Console.Clear();
                    Console.WriteLine("You chose to see our Cats");
                    Cat();
                    break;
                
                default:
                    Console.WriteLine("Check your spelling and try again");
                    view();
                    break;
            }
                
            }
        public void Dog()
        {
            string[] dogs = Enum.GetNames(typeof(dogbreed));
            string[] age = Enum.GetNames(typeof(age));
            Console.WriteLine("\nWe have several adorable dogs staying with us including:\n");
            Console.ResetColor();
            for (int i = 0; i < random.Next(7, dogs.Length); i++)
            {
                int randomage = random.Next(0, age.Length);
                Console.WriteLine("A " + dogs[i] + " that is " + age[randomage] + " years old");
            }
            Console.WriteLine("\n");
            whatsNext();
        }
        public void Cat()
        {
            string[] cats = Enum.GetNames(typeof(catbreed));
            string[] age = Enum.GetNames(typeof(age));
            Console.WriteLine("\nWe have several fabulous cats staying with us including:\n");
            for (int i = 0; i < cats.Length; i++)
            {
                int randomage = random.Next(0, age.Length);
                Console.WriteLine("A " + cats[i] + " that is " + age[randomage] + " years old");
            }
            Console.WriteLine("\n");
            whatsNext();
        }
        







        public void whatsNext()
            {
            Console.WriteLine("What would you like to do next? \nType Return for menu. \nType Exit to leave.");
            string UserChoice;
            UserChoice = Console.ReadLine();
            switch (UserChoice.ToLower())
                {
                case "return":
                    Console.Clear();
                    view();               
                    break;
                case "exit":
                    Console.WriteLine("Thanks for visiting the Humane Society.  Come back Soon!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Try again");
                    whatsNext();
                    break;
                }
            }
         
        }

   
}

