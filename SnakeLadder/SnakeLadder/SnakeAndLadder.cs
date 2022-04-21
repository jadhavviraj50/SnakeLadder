using System;
using System.Collections.Generic;
using System.Text;


namespace SnakeLadder
{
    //UC1
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

       
    }
}
