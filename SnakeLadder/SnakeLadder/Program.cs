namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder!");
            SnakeAndLadder player1 = new SnakeAndLadder();
            SnakeAndLadder player2 = new SnakeAndLadder();
            Console.WriteLine("Player 1: ");
            player1.Describe();
            Console.WriteLine("Player 2: ");
            player2.Describe();
            player1.PlayTillEnd(player2);
        }
    }
}
