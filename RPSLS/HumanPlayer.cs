using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {

        public HumanPlayer(string name) : base(name)
        {
        }

      
        public override void ChooseGesture()
        {
            Console.WriteLine($"{name}, choose your gesture:");
            foreach (string gesture in gestures)
            {
                Console.WriteLine($"- {gesture}");
            }

            string input;
            bool validInput = false;
            do
            {
                input = Console.ReadLine();
                if (gestures.Contains(input.ToLower()))
                {
                    chosenGesture = input.ToLower();
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid gesture. Please choose one from the list.");
                }
            } while (!validInput);
        }
    }
}
