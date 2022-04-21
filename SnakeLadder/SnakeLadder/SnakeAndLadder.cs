using System;
using System.Collections.Generic;
using System.Text;


namespace SnakeLadder
{
    //UC1 Single player at start position 0
    public class SnakeAndLadder
    {

        private int position;
        private bool winCheck;
        private int totalDieRoll;

        static Random random = new Random();

        public SnakeAndLadder()
        {
            position = 0;
            winCheck = false;
            totalDieRoll = 0;
        }

        public void Describe()
        {
            Console.WriteLine("Position: " + position);
        }

        //UC2 The Player rolls the die

        public void RollDie()
        {
            totalDieRoll++;
            int chkContinue = 0;
            int roll = random.Next(1, 7);
            Console.WriteLine("\nRolled: " + roll);
            if (winCheck is false)
                chkContinue = MovePlayer(roll);
            if (winCheck is false && chkContinue == 1)
                Option(roll);
            Describe();
        }
    }

}
