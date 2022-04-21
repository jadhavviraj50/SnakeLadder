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

        //UC3 Player then checks for the option

        private void Option(int roll)
        {
            int option = random.Next(0, 3);
            switch (option)
            {
                case 0:
                    Console.WriteLine("No Play");
                    break;
                case 1:
                    Ladder(roll);
                    break;
                case 2:
                    Snake(roll);
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }

        private void Snake(int roll)
        {
            Console.WriteLine("OOPS! Snake Trap!");
            Console.WriteLine("Going down by" + roll);
            MovePlayer(-roll);
        }

        private void Ladder(int roll)
        {
            Console.WriteLine("Yay ! & Ladder!");
            Console.WriteLine("Going up by " + roll);
            MovePlayer(roll);
        }

        //UC4 Position moves below 0 then restart
        private int CheckBoundary(int displacement)
        {
            if (position < 0)
            {
                position = 0;
                return 0;
            }
            else if (position > 100)
            {
                position -= displacement;
                Console.WriteLine("Oops! You shot past position 100");
                Console.WriteLine("You are moved back to previous position");
                return 0;
            }
            else
                return 1;
        }

        //UC5 Player gets to exact winning position 100

        private int MovePlayer(int displacement)
        {
            position += displacement;
            if (position == 100)
            {
                winCheck = true;
                return 0;
            }
            return CheckBoundary(displacement);
        }
    }

}
