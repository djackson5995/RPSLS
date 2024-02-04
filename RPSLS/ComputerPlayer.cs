using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {
        // Constructor
        public ComputerPlayer(string name) : base(name)
        {
        }

        // Override ChooseGesture method
        public override void ChooseGesture()
        {
            Random random = new Random();
            int index = random.Next(gestures.Count);
            chosenGesture = gestures[index];
        }
    }
}