using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock\n");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            int numberOfPlayers;
            bool validInput = false;

            do
            {
                Console.WriteLine("How many human players? (1 or 2)");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numberOfPlayers))
                {
                    if (numberOfPlayers == 1 || numberOfPlayers == 2)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter either 1 or 2.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            } while (!validInput);

            return numberOfPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("Enter player one's name:");
                string playerOneName = Console.ReadLine();
                playerOne = new HumanPlayer(playerOneName);
                playerTwo = new ComputerPlayer("Computer");
            }
            else if (numberOfHumanPlayers == 2)
            {
               
                Console.WriteLine("Enter player one's name:");
                string playerOneName = Console.ReadLine();
                playerOne = new HumanPlayer(playerOneName);

             
                Console.WriteLine("Enter player two's name:");
                string playerTwoName = Console.ReadLine();
                playerTwo = new HumanPlayer(playerTwoName);
            }
        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
        }
    }
}
